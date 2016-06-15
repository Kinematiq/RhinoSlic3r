namespace RhinoSlic3r
{
    ///<summary>
    /// <para>Every RhinoCommon .rhp assembly must have one and only one PlugIn-derived
    /// class. DO NOT create instances of this class yourself. It is the
    /// responsibility of Rhino to create an instance of this class.</para>
    /// <para>To complete plug-in information, please also see all PlugInDescription
    /// attributes in AssemblyInfo.cs (you might need to click "Project" ->
    /// "Show All Files" to see it in the "Solution Explorer" window).</para>
    ///</summary>
    public class RhinoSlic3rPlugIn : Rhino.PlugIns.PlugIn
    {
        public RhinoSlic3rPlugIn()
        {
            Instance = this;
        }
        ///<summary>Gets the only instance of the RhinoSlic3rPlugIn plug-in.</summary>
        public static RhinoSlic3rPlugIn Instance
        {
            get; private set;
        }
        // You can override methods here to change the plug-in behavior on
        // loading and shut down, add options pages to the Rhino _Option command
        // and mantain plug-in wide options in a document.
        /// <summary>
        /// Is called when the plug-in is being loaded.
        /// </summary>
        protected override Rhino.PlugIns.LoadReturnCode OnLoad(ref string errorMessage)
        {
            System.Type panelType = typeof(RhinoSlic3rUserControl);
            Rhino.UI.Panels.RegisterPanel(this, panelType, "RhinoSlic3r", RhinoSlic3r.Properties.Resources.Slic3r);
            return Rhino.PlugIns.LoadReturnCode.Success;
        }
        /// <summary>
        /// The tabbed dockbar user control
        /// </summary>
        public RhinoSlic3rUserControl UserControl
        {
            get;
            set;
        }
    }

    [System.Runtime.InteropServices.Guid("B3BCE788-B726-4D31-9C1F-4264270DD780")]
    public class MyOpenPanelCommand : Rhino.Commands.Command
    {
        public MyOpenPanelCommand() : base()
        {
            // Rhino only creates one instance of each command class defined in a
            // plug-in, so it is safe to store a reference in a static property.
            Instance = this;
        }
        ///<summary>The only instance of this command.</summary>
        public static MyOpenPanelCommand Instance
        {
            get;
            set;
        }
        ///<returns>The command name as it appears on the Rhino command line.</returns>
        public override string EnglishName
        {
            get { return "RhinoSlic3r"; }
        }
        protected override Rhino.Commands.Result RunCommand(Rhino.RhinoDoc doc, Rhino.Commands.RunMode mode)
        {
            System.Type type = typeof(RhinoSlic3rUserControl);
            Rhino.UI.Panels.OpenPanel(type.GUID);
            return Rhino.Commands.Result.Success;
        }
    }
}