using System.IO;

namespace WindowsFormsApp1
{
    partial class MainUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUi));
            this.StartApps = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.AddedAppsList = new System.Windows.Forms.Label();
            this.AppListPath = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mogusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAppBTN = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GroupSelect = new System.Windows.Forms.ComboBox();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartApps
            // 
            this.StartApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartApps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartApps.Location = new System.Drawing.Point(894, 483);
            this.StartApps.Name = "StartApps";
            this.StartApps.Size = new System.Drawing.Size(162, 82);
            this.StartApps.TabIndex = 0;
            this.StartApps.Text = "Start Apps";
            this.StartApps.UseVisualStyleBackColor = true;
            this.StartApps.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(71, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Apps";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.Location = new System.Drawing.Point(397, 87);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(97, 37);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "Clear List";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // AddedAppsList
            // 
            this.AddedAppsList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddedAppsList.AutoSize = true;
            this.AddedAppsList.Location = new System.Drawing.Point(513, 52);
            this.AddedAppsList.Name = "AddedAppsList";
            this.AddedAppsList.Size = new System.Drawing.Size(45, 13);
            this.AddedAppsList.TabIndex = 11;
            this.AddedAppsList.Text = "App List";
            // 
            // AppListPath
            // 
            this.AppListPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AppListPath.AutoSize = true;
            this.AppListPath.Location = new System.Drawing.Point(513, 99);
            this.AppListPath.Name = "AppListPath";
            this.AppListPath.Size = new System.Drawing.Size(33, 13);
            this.AppListPath.TabIndex = 12;
            this.AppListPath.Text = "None";
            // 
            // PathLabel
            // 
            this.PathLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(513, 80);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(29, 13);
            this.PathLabel.TabIndex = 13;
            this.PathLabel.Text = "Path";
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1068, 24);
            this.MenuBar.TabIndex = 20;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.saveToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.SaveToolStripMenuItem1_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.GitHubToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.DarkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.LightToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // mogusToolStripMenuItem
            // 
            this.mogusToolStripMenuItem.Name = "mogusToolStripMenuItem";
            this.mogusToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // amonToolStripMenuItem
            // 
            this.amonToolStripMenuItem.Name = "amonToolStripMenuItem";
            this.amonToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // SelectAppBTN
            // 
            this.SelectAppBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectAppBTN.Location = new System.Drawing.Point(74, 87);
            this.SelectAppBTN.Name = "SelectAppBTN";
            this.SelectAppBTN.Size = new System.Drawing.Size(97, 37);
            this.SelectAppBTN.TabIndex = 21;
            this.SelectAppBTN.Text = "Select App";
            this.SelectAppBTN.UseVisualStyleBackColor = true;
            this.SelectAppBTN.Click += new System.EventHandler(this.SelectAppBTN_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GroupSelect
            // 
            this.GroupSelect.FormattingEnabled = true;
            this.GroupSelect.Location = new System.Drawing.Point(25, 544);
            this.GroupSelect.Name = "GroupSelect";
            this.GroupSelect.Size = new System.Drawing.Size(121, 21);
            this.GroupSelect.TabIndex = 22;
            this.GroupSelect.Text = "Select Group";
            this.GroupSelect.SelectedIndexChanged += new System.EventHandler(this.GroupSelect_SelectedIndexChanged);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // MainUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 577);
            this.Controls.Add(this.GroupSelect);
            this.Controls.Add(this.SelectAppBTN);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.AppListPath);
            this.Controls.Add(this.AddedAppsList);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartApps);
            this.Controls.Add(this.MenuBar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.Name = "MainUi";
            this.Text = "AppBooter";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button StartApps;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button ClearBtn;
        internal System.Windows.Forms.Label AddedAppsList;
        internal System.Windows.Forms.Label AppListPath;
        internal System.Windows.Forms.Label PathLabel;
        internal System.Windows.Forms.MenuStrip MenuBar;
        internal System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem mogusToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem amonToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        internal System.Windows.Forms.Button SelectAppBTN;
        internal System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.ComboBox GroupSelect;
        internal System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

