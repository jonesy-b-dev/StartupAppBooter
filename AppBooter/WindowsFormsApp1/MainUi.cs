using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainUi : Form
    {
        public MainUi()
        {
            InitializeComponent();
        }

        //Startup the programms
        private void button1_Click(object sender, EventArgs e)
        {
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = "AppBooter";
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            ExternalProcess.Start();
            ExternalProcess.WaitForExit();
        }

        string paths;
        string exes;

        private void Add_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "" || exeField.Text == "") || (textBox2.Text == "" && exeField.Text == ""))
            {
                MessageBox.Show("There is a empty field");
            }
            else
            {
                AddApp(textBox2.Text, exeField.Text, false);
                textBox2.Clear();
                exeField.Clear();
            }
        }

        //Clears all the apps from the boot list
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists("ActualAppBooter.bat"))
            {
                ClearAppList();
            }
            else
            {
                File.Create("ActualAppBooter.bat");
                ClearAppList();
            }
        }

        void ClearAppList()
        {
            TextWriter txt = new StreamWriter("ActualAppBooter.bat");
            txt.WriteAsync("");
            AppListPath.Text = "";
            AppListExe.Text = "";
            paths = "";
            exes = "";
            txt.Close();
        }

        void AddApp(string path, string exe, bool fromFile)
        {
            if (File.Exists("ActualAppBooter.bat"))
            {
                AppToList(path, exe, fromFile);
            }
            else
            {
                File.Create("ActualAppBooter.bat");
                AppToList(path, exe, fromFile);
            }

        }

        void AppToList(string path, string exe, bool fromFile)
        {
            File.AppendAllText(@"ActualAppBooter.bat", "cd " + path + "\n" + "start " + exe + Environment.NewLine);
            paths = paths + textBox2.Text + "\n";
            exes = exes + exeField.Text + "\n";
            AppListPath.Text = paths;
            AppListExe.Text = exes;
        }

        //Menu toolbar
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet");
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet");
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/jonesy-b-dev/StartupAppBooter");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AppBooter \nVersion: 0.0.1 \nCopyright © 2022- 2022 Jonas de Bruin \n\nAppBooter is a app created by Jonas de Bruin and used to boot custom apps in bulk at any time. Currently in early development");
        }
    }
}