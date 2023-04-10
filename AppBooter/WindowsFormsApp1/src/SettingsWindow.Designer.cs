namespace WindowsFormsApp1
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

            /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.ThemeCombo = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.RestoreDirCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Location = new System.Drawing.Point(12, 18);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(40, 13);
            this.ThemeLabel.TabIndex = 0;
            this.ThemeLabel.Text = "Theme";
            // 
            // ThemeCombo
            // 
            this.ThemeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemeCombo.FormattingEnabled = true;
            this.ThemeCombo.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.ThemeCombo.Location = new System.Drawing.Point(80, 18);
            this.ThemeCombo.MaxDropDownItems = 2;
            this.ThemeCombo.Name = "ThemeCombo";
            this.ThemeCombo.Size = new System.Drawing.Size(71, 21);
            this.ThemeCombo.TabIndex = 1;
            this.ThemeCombo.SelectedIndexChanged += new System.EventHandler(this.ThemeCombo_SelectedIndexChanged);
            // 
            // RestoreDirCB
            // 
            this.RestoreDirCB.AutoSize = true;
            this.RestoreDirCB.Checked = true;
            this.RestoreDirCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RestoreDirCB.Location = new System.Drawing.Point(15, 55);
            this.RestoreDirCB.Name = "RestoreDirCB";
            this.RestoreDirCB.Size = new System.Drawing.Size(201, 17);
            this.RestoreDirCB.TabIndex = 2;
            this.RestoreDirCB.Text = "Restore directory when selecting app";
            this.RestoreDirCB.UseVisualStyleBackColor = true;
            this.RestoreDirCB.CheckedChanged += new System.EventHandler(this.RestoreDirCB_CheckedChanged);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.RestoreDirCB);
            this.Controls.Add(this.ThemeCombo);
            this.Controls.Add(this.ThemeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label ThemeLabel;
        internal System.Windows.Forms.ComboBox ThemeCombo;
        internal System.Windows.Forms.BindingSource bindingSource1;
        internal System.Windows.Forms.CheckBox RestoreDirCB;
    }
}