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
            this.label2 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.exeField = new System.Windows.Forms.TextBox();
            this.exeFieldTxt = new System.Windows.Forms.Label();
            this.AddedAppsList = new System.Windows.Forms.Label();
            this.AppListPath = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.AppListExe = new System.Windows.Forms.Label();
            this.pathField = new System.Windows.Forms.TextBox();
            this.ExeLabel2 = new System.Windows.Forms.Label();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mogusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.StartApps.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Apps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Input full path to app exe or shortcut here";
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Location = new System.Drawing.Point(71, 125);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 7;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.Location = new System.Drawing.Point(71, 155);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "Clear List";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // exeField
            // 
            this.exeField.Location = new System.Drawing.Point(369, 98);
            this.exeField.Name = "exeField";
            this.exeField.Size = new System.Drawing.Size(129, 20);
            this.exeField.TabIndex = 9;
            // 
            // exeFieldTxt
            // 
            this.exeFieldTxt.AutoSize = true;
            this.exeFieldTxt.Location = new System.Drawing.Point(369, 80);
            this.exeFieldTxt.Name = "exeFieldTxt";
            this.exeFieldTxt.Size = new System.Drawing.Size(76, 13);
            this.exeFieldTxt.TabIndex = 10;
            this.exeFieldTxt.Text = "Enter exe here";
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
            // AppListExe
            // 
            this.AppListExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AppListExe.AutoSize = true;
            this.AppListExe.Location = new System.Drawing.Point(891, 99);
            this.AppListExe.Name = "AppListExe";
            this.AppListExe.Size = new System.Drawing.Size(33, 13);
            this.AppListExe.TabIndex = 15;
            this.AppListExe.Text = "None";
            // 
            // pathField
            // 
            this.pathField.Location = new System.Drawing.Point(74, 97);
            this.pathField.Name = "pathField";
            this.pathField.Size = new System.Drawing.Size(289, 20);
            this.pathField.TabIndex = 18;
            // 
            // ExeLabel2
            // 
            this.ExeLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExeLabel2.AutoSize = true;
            this.ExeLabel2.Location = new System.Drawing.Point(891, 80);
            this.ExeLabel2.Name = "ExeLabel2";
            this.ExeLabel2.Size = new System.Drawing.Size(25, 13);
            this.ExeLabel2.TabIndex = 19;
            this.ExeLabel2.Text = "Exe";
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1068, 24);
            this.MenuBar.TabIndex = 20;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
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
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            // MainUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 577);
            this.Controls.Add(this.ExeLabel2);
            this.Controls.Add(this.pathField);
            this.Controls.Add(this.AppListExe);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.AppListPath);
            this.Controls.Add(this.AddedAppsList);
            this.Controls.Add(this.exeFieldTxt);
            this.Controls.Add(this.exeField);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label2);
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

        private System.Windows.Forms.Button StartApps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.TextBox exeField;
        private System.Windows.Forms.Label exeFieldTxt;
        private System.Windows.Forms.Label AddedAppsList;
        private System.Windows.Forms.Label AppListPath;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label AppListExe;
        private System.Windows.Forms.TextBox pathField;
        private System.Windows.Forms.Label ExeLabel2;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mogusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

