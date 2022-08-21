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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.exeField = new System.Windows.Forms.TextBox();
            this.exeFieldTxt = new System.Windows.Forms.Label();
            this.AddedAppsList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartApps
            // 
            this.StartApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.AddedAppsList.AutoSize = true;
            this.AddedAppsList.Location = new System.Drawing.Point(663, 52);
            this.AddedAppsList.Name = "AddedAppsList";
            this.AddedAppsList.Size = new System.Drawing.Size(64, 13);
            this.AddedAppsList.TabIndex = 11;
            this.AddedAppsList.Text = "Added apps";
            // 
            // MainUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 577);
            this.Controls.Add(this.AddedAppsList);
            this.Controls.Add(this.exeFieldTxt);
            this.Controls.Add(this.exeField);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartApps);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUi";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartApps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.TextBox exeField;
        private System.Windows.Forms.Label exeFieldTxt;
        private System.Windows.Forms.Label AddedAppsList;
    }
}

