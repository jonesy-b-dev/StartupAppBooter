using System;
using System.Diagnostics;
using System.IO;
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
            BatFileHandler.StartUpApps();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            FileHandler.AddAppToList(pathField, exeField, AppListPath, AppListExe);
        }

        //Clears all the apps from the boot list
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists("ActualAppBooter.bat"))
            {
                FileHandler.ClearAppList(AppListPath, AppListExe);
            }
            else
            {
                File.Create("ActualAppBooter.bat");
                FileHandler.ClearAppList(AppListPath, AppListExe);
            }
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