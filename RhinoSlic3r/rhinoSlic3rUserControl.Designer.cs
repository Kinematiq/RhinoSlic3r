namespace RhinoSlic3r
{
    partial class RhinoSlic3rUserControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.SliceItButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenSlic3rButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InfillDensityLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.OpenGcodeButton = new System.Windows.Forms.Button();
            this.InfillDensityUpDown = new System.Windows.Forms.NumericUpDown();
            this.VaseProfilcheckBox = new System.Windows.Forms.CheckBox();
            this.LayerHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SolidInfillPatternComboBox = new System.Windows.Forms.ComboBox();
            this.InfillPatternComboBox = new System.Windows.Forms.ComboBox();
            this.InfillDensityTrackBar = new System.Windows.Forms.TrackBar();
            this.SupportCheckBox = new System.Windows.Forms.CheckBox();
            this.SettingsComboBox = new System.Windows.Forms.ComboBox();
            this.OpenGcodeFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.InfillDensityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfillDensityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SliceItButton
            // 
            this.SliceItButton.Location = new System.Drawing.Point(7, 188);
            this.SliceItButton.Name = "SliceItButton";
            this.SliceItButton.Size = new System.Drawing.Size(190, 30);
            this.SliceItButton.TabIndex = 0;
            this.SliceItButton.Text = "Slice It!";
            this.SliceItButton.UseVisualStyleBackColor = true;
            this.SliceItButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Slic3r settings file:";
            // 
            // OpenSlic3rButton
            // 
            this.OpenSlic3rButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenSlic3rButton.Location = new System.Drawing.Point(7, 34);
            this.OpenSlic3rButton.Name = "OpenSlic3rButton";
            this.OpenSlic3rButton.Size = new System.Drawing.Size(390, 27);
            this.OpenSlic3rButton.TabIndex = 3;
            this.OpenSlic3rButton.Text = "Open Slic3r for advance parameters";
            this.OpenSlic3rButton.UseVisualStyleBackColor = true;
            this.OpenSlic3rButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Layer height:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 64);
            this.label5.MinimumSize = new System.Drawing.Size(30, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "mm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Infill density:";
            // 
            // InfillDensityLabel
            // 
            this.InfillDensityLabel.AutoSize = true;
            this.InfillDensityLabel.Location = new System.Drawing.Point(362, 94);
            this.InfillDensityLabel.Name = "InfillDensityLabel";
            this.InfillDensityLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InfillDensityLabel.Size = new System.Drawing.Size(0, 17);
            this.InfillDensityLabel.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Infill pattern:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Solid fill pattern:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "RhinoSlic3r V0.2.0 using Slic3r V1.2.9";
            // 
            // OpenGcodeButton
            // 
            this.OpenGcodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenGcodeButton.Location = new System.Drawing.Point(207, 188);
            this.OpenGcodeButton.Name = "OpenGcodeButton";
            this.OpenGcodeButton.Size = new System.Drawing.Size(190, 30);
            this.OpenGcodeButton.TabIndex = 25;
            this.OpenGcodeButton.Text = "Read G-code file";
            this.OpenGcodeButton.UseVisualStyleBackColor = true;
            this.OpenGcodeButton.Click += new System.EventHandler(this.OpenGcodeButton_Click);
            // 
            // InfillDensityUpDown
            // 
            this.InfillDensityUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfillDensityUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::RhinoSlic3r.Properties.Settings.Default, "InfillDensity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InfillDensityUpDown.Location = new System.Drawing.Point(344, 94);
            this.InfillDensityUpDown.Name = "InfillDensityUpDown";
            this.InfillDensityUpDown.Size = new System.Drawing.Size(50, 22);
            this.InfillDensityUpDown.TabIndex = 24;
            this.InfillDensityUpDown.Value = global::RhinoSlic3r.Properties.Settings.Default.InfillDensity;
            // 
            // VaseProfilcheckBox
            // 
            this.VaseProfilcheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VaseProfilcheckBox.AutoSize = true;
            this.VaseProfilcheckBox.Checked = global::RhinoSlic3r.Properties.Settings.Default.Vase;
            this.VaseProfilcheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RhinoSlic3r.Properties.Settings.Default, "Vase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.VaseProfilcheckBox.Location = new System.Drawing.Point(297, 64);
            this.VaseProfilcheckBox.Name = "VaseProfilcheckBox";
            this.VaseProfilcheckBox.Size = new System.Drawing.Size(97, 21);
            this.VaseProfilcheckBox.TabIndex = 23;
            this.VaseProfilcheckBox.Text = "Vase profil";
            this.VaseProfilcheckBox.UseVisualStyleBackColor = true;
            // 
            // LayerHeightNumericUpDown
            // 
            this.LayerHeightNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayerHeightNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::RhinoSlic3r.Properties.Settings.Default, "Layer_height", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LayerHeightNumericUpDown.DecimalPlaces = 2;
            this.LayerHeightNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.LayerHeightNumericUpDown.Location = new System.Drawing.Point(96, 64);
            this.LayerHeightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LayerHeightNumericUpDown.MinimumSize = new System.Drawing.Size(60, 0);
            this.LayerHeightNumericUpDown.Name = "LayerHeightNumericUpDown";
            this.LayerHeightNumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.LayerHeightNumericUpDown.TabIndex = 22;
            this.LayerHeightNumericUpDown.Value = global::RhinoSlic3r.Properties.Settings.Default.Layer_height;
            // 
            // SolidInfillPatternComboBox
            // 
            this.SolidInfillPatternComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SolidInfillPatternComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RhinoSlic3r.Properties.Settings.Default, "SolidInfillPattern", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SolidInfillPatternComboBox.FormattingEnabled = true;
            this.SolidInfillPatternComboBox.Items.AddRange(new object[] {
            "Rectilinear",
            "Concentric",
            "Hilbert Curve",
            "Archimedean Chords",
            "Octagram Spiral"});
            this.SolidInfillPatternComboBox.Location = new System.Drawing.Point(131, 158);
            this.SolidInfillPatternComboBox.Name = "SolidInfillPatternComboBox";
            this.SolidInfillPatternComboBox.Size = new System.Drawing.Size(266, 24);
            this.SolidInfillPatternComboBox.TabIndex = 20;
            this.SolidInfillPatternComboBox.Text = global::RhinoSlic3r.Properties.Settings.Default.SolidInfillPattern;
            // 
            // InfillPatternComboBox
            // 
            this.InfillPatternComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfillPatternComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RhinoSlic3r.Properties.Settings.Default, "InfillPattern", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InfillPatternComboBox.FormattingEnabled = true;
            this.InfillPatternComboBox.Items.AddRange(new object[] {
            "Rectilinear",
            "Line",
            "Concentric",
            "Honeycomb",
            "3D Honeycomb",
            "Hilbert Curve",
            "Archimedean Chords",
            "Octagram Spiral"});
            this.InfillPatternComboBox.Location = new System.Drawing.Point(131, 128);
            this.InfillPatternComboBox.Name = "InfillPatternComboBox";
            this.InfillPatternComboBox.Size = new System.Drawing.Size(266, 24);
            this.InfillPatternComboBox.TabIndex = 19;
            this.InfillPatternComboBox.Text = global::RhinoSlic3r.Properties.Settings.Default.InfillPattern;
            // 
            // InfillDensityTrackBar
            // 
            this.InfillDensityTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfillDensityTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::RhinoSlic3r.Properties.Settings.Default, "InfillDensity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InfillDensityTrackBar.LargeChange = 10;
            this.InfillDensityTrackBar.Location = new System.Drawing.Point(96, 92);
            this.InfillDensityTrackBar.Maximum = 100;
            this.InfillDensityTrackBar.Name = "InfillDensityTrackBar";
            this.InfillDensityTrackBar.Size = new System.Drawing.Size(242, 56);
            this.InfillDensityTrackBar.TabIndex = 15;
            this.InfillDensityTrackBar.TickFrequency = 10;
            this.InfillDensityTrackBar.Value = global::RhinoSlic3r.Properties.Settings.Default.InfillDensity;
            // 
            // SupportCheckBox
            // 
            this.SupportCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SupportCheckBox.AutoSize = true;
            this.SupportCheckBox.Checked = global::RhinoSlic3r.Properties.Settings.Default.Support;
            this.SupportCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RhinoSlic3r.Properties.Settings.Default, "Support", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SupportCheckBox.Location = new System.Drawing.Point(194, 64);
            this.SupportCheckBox.Name = "SupportCheckBox";
            this.SupportCheckBox.Size = new System.Drawing.Size(87, 21);
            this.SupportCheckBox.TabIndex = 9;
            this.SupportCheckBox.Text = "Supports";
            this.SupportCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsComboBox
            // 
            this.SettingsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RhinoSlic3r.Properties.Settings.Default, "PrintSettings", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SettingsComboBox.FormattingEnabled = true;
            this.SettingsComboBox.Location = new System.Drawing.Point(131, 4);
            this.SettingsComboBox.Name = "SettingsComboBox";
            this.SettingsComboBox.Size = new System.Drawing.Size(266, 24);
            this.SettingsComboBox.TabIndex = 4;
            this.SettingsComboBox.Text = global::RhinoSlic3r.Properties.Settings.Default.PrintSettings;
            this.SettingsComboBox.DropDown += new System.EventHandler(this.SettingsComboBox_DropDown);
            // 
            // OpenGcodeFileDialog
            // 
            this.OpenGcodeFileDialog.FileName = "G-code file";
            this.OpenGcodeFileDialog.Filter = "G-code files|*.gcode";
            this.OpenGcodeFileDialog.InitialDirectory = global::RhinoSlic3r.Properties.Settings.Default.Gcodedir;
            this.OpenGcodeFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // RhinoSlic3rUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.OpenGcodeButton);
            this.Controls.Add(this.InfillDensityUpDown);
            this.Controls.Add(this.VaseProfilcheckBox);
            this.Controls.Add(this.LayerHeightNumericUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SolidInfillPatternComboBox);
            this.Controls.Add(this.InfillPatternComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InfillDensityLabel);
            this.Controls.Add(this.InfillDensityTrackBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SupportCheckBox);
            this.Controls.Add(this.SettingsComboBox);
            this.Controls.Add(this.OpenSlic3rButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SliceItButton);
            this.Name = "RhinoSlic3rUserControl";
            this.Size = new System.Drawing.Size(400, 300);
            this.Load += new System.EventHandler(this.RhinoSlic3rUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InfillDensityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfillDensityTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SliceItButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenSlic3rButton;
        private System.Windows.Forms.ComboBox SettingsComboBox;
        private System.Windows.Forms.CheckBox SupportCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar InfillDensityTrackBar;
        private System.Windows.Forms.Label InfillDensityLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox InfillPatternComboBox;
        private System.Windows.Forms.ComboBox SolidInfillPatternComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown LayerHeightNumericUpDown;
        private System.Windows.Forms.CheckBox VaseProfilcheckBox;
        private System.Windows.Forms.NumericUpDown InfillDensityUpDown;
        private System.Windows.Forms.Button OpenGcodeButton;
        private System.Windows.Forms.OpenFileDialog OpenGcodeFileDialog;
    }
}
