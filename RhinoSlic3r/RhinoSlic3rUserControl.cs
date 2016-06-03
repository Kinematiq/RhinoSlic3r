using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rhino;
using System.IO;
using System.Diagnostics;
using Rhino.Geometry;
using System.Globalization;

namespace RhinoSlic3r
{
    [System.Runtime.InteropServices.Guid("b2c8a7d7-7227-454e-ba08-abf351cc1908")]
    public partial class RhinoSlic3rUserControl : UserControl
    {
        public RhinoSlic3rUserControl()
        {
            InitializeComponent();
            RhinoApp.Closing += OnClosing;
        }

        //Initialize UI
        public void RhinoSlic3rUserControl_Load(object sender, EventArgs e)
        {
            loadsettingsfiles();
        }

        //Show infill value
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            InfillDensityLabel.Text = InfillDensityTrackBar.Value.ToString() + @"%";
        }

        //Dropdown settings opened
        private void SettingsComboBox_DropDown(object sender, EventArgs e)
        {
            loadsettingsfiles();
        }

        //Load settings files
        private void loadsettingsfiles()
        {
            try
            {
                //Get config files
                string[] SettingsFiles = Directory.GetFiles(@"C:\Kinematiq\RhinoSlic3r\Slic3r", "*.ini").Select(path => Path.GetFileName(path)).ToArray();

                SettingsComboBox.Items.Clear();
                foreach (string item in SettingsFiles)
                {
                    SettingsComboBox.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Select object and start slicing
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic arrObjs = null;
                dynamic strFileName = null;
                dynamic strSett = null;
                Rhino.RhinoDoc doc = Rhino.RhinoDoc.ActiveDoc;

                //Get Objects ID to slice
                Rhino.Input.Custom.GetObject go = new Rhino.Input.Custom.GetObject();
                go.SetCommandPrompt("Select objects to slice");
                go.GroupSelect = true;
                go.AcceptNothing(true);
                go.GetMultiple(1, 0);
                if (go.CommandResult() != Rhino.Commands.Result.Success)
                    return;
                List<Guid> ids = new List<Guid>();
                for (int i = 0; i < go.ObjectCount; i++)
                {
                    ids.Add(go.Object(i).ObjectId);
                }
                arrObjs = ids;

                //Get Center
                BoundingBox bBox = BoundingBox.Unset;

                var selected_objects = go.Objects().ToList();
                foreach (var obj in go.Objects())
                {
                    BoundingBox bbObj = obj.Geometry().GetBoundingBox(true);
                    bBox.Union(bbObj); // union the object bounding box with the overall bounding box
                }
                Point3d centerpoint = bBox.Center;

                //Get the current name
                    strFileName = @"C:\Kinematiq\RhinoSlic3r\Temp\" + System.DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".stl";

                //Get STL settings
                strSett = STLSettings();

                //Selects the objects
                doc.Objects.Select(arrObjs);

                //Runs the export using the file name/path and STL settings
                RhinoApp.RunScript("-_Export " + '\u0022' + strFileName + '\u0022' + " " + strSett, false);

                //Run Slic3r with stl file and settings 
                string stl = strFileName;
                string printcenter = " --print-center " + centerpoint.X.ToString().Replace(",", ".") + "," + centerpoint.Y.ToString().Replace(",", ".");
                string height = " --layer-height " + LayerHeightNumericUpDown.Value.ToString().Replace(",", ".");
                string cooling = " --cooling";
                string support = "";
                if (SupportCheckBox.Checked == true){support = " --support-material"; }
                string fillpatern = " --fill-pattern " + InfillPatternComboBox.Text;
                string solidfillpatern = " --solid-fill-pattern " + SolidInfillPatternComboBox.Text;
                string density = " --fill-density " + InfillDensityTrackBar.Value + "%";
                string settings = @" --load " + SettingsComboBox.Text;
                string vase = "";
                if (VaseProfilcheckBox.Checked == true) { vase = " --spiral-vase"; }

                string arguments = 
                    (stl +
                    printcenter +
                    settings+
                    height + 
                    cooling + 
                    support + 
                    vase +
                    fillpatern + 
                    solidfillpatern +
                    density 

                    ).ToLower();

                Rhino.RhinoApp.WriteLine(arguments);

                ProcessStartInfo procStartInfo = new ProcessStartInfo(@"C:\Kinematiq\RhinoSlic3r\Slic3r\Slic3r.exe", arguments);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;

                Process proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.OutputDataReceived += new DataReceivedEventHandler(proc_OutputDataReceived);
                proc.Start();
                proc.BeginOutputReadLine();
                proc.WaitForExit();

                //Read Gcode and create polyline
                String Gcode = strFileName.Substring(0, strFileName.Length - 3) + "gcode";

                    int LineN = 0;
                    List<string> LineList = new List<string>();
                    LineList = File.ReadLines(Gcode).ToList();

                    System.Text.RegularExpressions.Regex regX = new System.Text.RegularExpressions.Regex("(?<=X)(.\\d*).\\d*");
                    System.Text.RegularExpressions.Regex regY = new System.Text.RegularExpressions.Regex("(?<=Y)(.\\d*).\\d*");
                    System.Text.RegularExpressions.Regex regZ = new System.Text.RegularExpressions.Regex("(?<=Z)(.\\d*).\\d*");

                    Point3d point = new Point3d();
                    Rhino.Collections.Point3dList points = new Rhino.Collections.Point3dList();

                //Parse GCode line to construct points
                for (LineN = 0; LineN < LineList.Count; LineN++)
                    {
                        if (LineList[LineN].StartsWith("G0 ") || LineList[LineN].StartsWith("G1 ") || LineList[LineN].StartsWith("G2 ") || LineList[LineN].StartsWith("G3 ")) 
                        {
                            if (regX.Match(LineList[LineN]).Success)
                            {
                                point.X = double.Parse(regX.Match(LineList[LineN]).ToString(), NumberStyles.Any, CultureInfo.InvariantCulture);
                            }
                            if (regY.Match(LineList[LineN]).Success)
                            {
                                point.Y = double.Parse(regY.Match(LineList[LineN]).ToString(), NumberStyles.Any, CultureInfo.InvariantCulture);
                            }
                            if (regZ.Match(LineList[LineN]).Success)
                            {
                                point.Z = double.Parse(regZ.Match(LineList[LineN]).ToString(), NumberStyles.Any, CultureInfo.InvariantCulture);
                            }
                        
                        points.Add(point);
                        }
                    }

                    //Remove first and last 0,0,0 points
                points.RemoveAt(0);
                points.RemoveAt(0);
                points.RemoveAt(0);

                //Make a curve form the list of points
                Rhino.Geometry.NurbsCurve nc = Rhino.Geometry.NurbsCurve.Create(false, 1, points);
                nc.Translate(0, 0, bBox.Min.Z);
                if (nc != null && nc.IsValid)
                {
                    //Add a GCode layer to the model
                    Rhino.DocObjects.ObjectAttributes att = doc.CreateDefaultAttributes();
                    dynamic layer_index = doc.Layers.Find("GCode", true);
                    if (layer_index > 0)
                    {
                        doc.Layers.Purge(layer_index, true);
                        layer_index = doc.Layers.Add("GCode", System.Drawing.Color.Red);
                    }
                    else
                    {
                        layer_index = doc.Layers.Add("GCode", System.Drawing.Color.Red);
                    }
                    att.LayerIndex = layer_index;
                    att.ColorSource = Rhino.DocObjects.ObjectColorSource.ColorFromLayer;

                    if (doc.Objects.AddCurve(nc,att) != Guid.Empty)
                    {
                        doc.Views.Redraw();
                    }
                }

                //Open Gcode folder
                Process.Start(@"C:\Kinematiq\RhinoSlic3r\Temp\");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
            }
        }

        //Log
        void proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                string newLine = e.Data.Trim();
                MethodInvoker append = () => Rhino.RhinoApp.WriteLine(newLine);
                BeginInvoke(append);
            }
        }

        //STL Settings
        public object STLSettings()
        {
            object functionReturnValue = null;

            functionReturnValue = null;
            dynamic str1 = null;
            dynamic str2 = null;
            dynamic str3 = null;
            dynamic str4 = null;
            dynamic str5 = null;
            dynamic str6 = null;
            dynamic str7 = null;
            dynamic str8 = null;
            dynamic str9 = null;
            dynamic str10 = null;
            dynamic str11 = null;
            dynamic str12 = null;
            dynamic str13 = null;
            dynamic str14 = null;
            dynamic str15 = null;
            dynamic str16 = null;
            dynamic str17 = null;
            dynamic str18 = null;
            dynamic strComb = null;

            str1 = "_ExportFileAs=_Binary ";
            str2 = "_ExportUnfinishedObjects=_Yes ";
            str3 = "_UseSimpleDialog=_No ";
            str4 = "_UseSimpleParameters=_No ";
            str5 = "_Enter _DetailedOptions ";
            str6 = "_JaggedSeams=_No ";
            str7 = "_PackTextures=_No ";
            str8 = "_Refine=_No ";
            str9 = "_SimplePlane=_No ";
            str10 = "_Weld=_No ";
            str11 = "_AdvancedOptions ";
            str12 = "_Angle=0.0 ";
            str13 = "_AspectRatio=0.0 ";
            str14 = "_Distance=0.01 ";
            str15 = "_Grid=0.0 ";
            str16 = "_MaxEdgeLength=1 ";
            str17 = "_MinEdgeLength=0 ";
            str18 = "_Enter _Enter";

            strComb = str1 + str2 + str3 + str4 + str5 + str6 + str7 + str8 + str9 + str10;
            strComb = strComb + str11 + str12 + str13 + str14 + str15 + str16 + str17 + str18;

            functionReturnValue = strComb;
            return functionReturnValue;
        }

        //Open Slic3r
        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Kinematiq\RhinoSlic3r\Slic3r\Slic3r.exe", "");
        }

        //Save settings on closing
        public static void OnClosing(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        //Open G-code file
        private void OpenGcodeButton_Click(object sender, EventArgs e)
        {
            OpenGcodeFileDialog.ShowDialog();
        }

        //Read Gcode and create polyline
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            String Gcode = OpenGcodeFileDialog.FileName;

            dynamic LineN = 0;
            List<string> LineList = new List<string>();
            LineList = File.ReadLines(Gcode).ToList();

            System.Text.RegularExpressions.Regex regX = new System.Text.RegularExpressions.Regex("(?<=X)(.\\d*).\\d*");
            System.Text.RegularExpressions.Regex regY = new System.Text.RegularExpressions.Regex("(?<=Y)(.\\d*).\\d*");
            System.Text.RegularExpressions.Regex regZ = new System.Text.RegularExpressions.Regex("(?<=Z)(.\\d*).\\d*");

            Point3d point = new Point3d();
            Rhino.Collections.Point3dList points = new Rhino.Collections.Point3dList();

            //Read GCode line to construct points
            for (LineN = 0; LineN < LineList.Count; LineN++)
            {
                if (LineList[LineN].StartsWith("G0 ") || LineList[LineN].StartsWith("G1 ") || LineList[LineN].StartsWith("G2 ") || LineList[LineN].StartsWith("G3 "))
                {
                    if (regX.Match(LineList[LineN]).Success)
                    {
                        point.X = double.Parse(regX.Match(LineList[LineN]).ToString(), NumberStyles.Any, CultureInfo.InvariantCulture);
                    }
                    if (regY.Match(LineList[LineN]).Success)
                    {
                        point.Y = double.Parse(regY.Match(LineList[LineN]).ToString(), NumberStyles.Any, CultureInfo.InvariantCulture);
                    }
                    if (regZ.Match(LineList[LineN]).Success)
                    {
                        point.Z = double.Parse(regZ.Match(LineList[LineN]).ToString(), NumberStyles.Any, CultureInfo.InvariantCulture);
                    }

                    points.Add(point);
                }
            }

            //Remove first and last 0,0,0 points
            points.RemoveAt(0);
            points.RemoveAt(0);
            points.RemoveAt(0);

            //Make a curve form the list of points
            Rhino.Geometry.NurbsCurve nc = Rhino.Geometry.NurbsCurve.Create(false, 1, points);
            if (nc != null && nc.IsValid)
            {
                //Add a GCode layer to the model
                Rhino.DocObjects.ObjectAttributes att = RhinoDoc.ActiveDoc.CreateDefaultAttributes();
                dynamic layer_index = RhinoDoc.ActiveDoc.Layers.Find("GCode", true);
                if (layer_index > 0)
                {
                    RhinoDoc.ActiveDoc.Layers.Purge(layer_index, true);
                    layer_index = RhinoDoc.ActiveDoc.Layers.Add("GCode", System.Drawing.Color.Red);
                }
                else
                {
                    layer_index = RhinoDoc.ActiveDoc.Layers.Add("GCode", System.Drawing.Color.Red);
                }
                att.LayerIndex = layer_index;
                att.ColorSource = Rhino.DocObjects.ObjectColorSource.ColorFromLayer;

                if (RhinoDoc.ActiveDoc.Objects.AddCurve(nc, att) != Guid.Empty)
                {
                    RhinoDoc.ActiveDoc.Views.Redraw();
                }
            }
        }


    }
}
