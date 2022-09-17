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

        //Startup the programms button
        private void button1_Click(object sender, EventArgs e)
        {
            BatFileHandler.StartUpApps();
        }

        //Add app button
        private void Add_Click(object sender, EventArgs e)
        {
            FileHandler.AddAppToList(pathField, exeField, AppListPath, AppListExe);
            FileHandler.AddAppToGroup();
        }

        //Clears all the apps from the boot list
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            //Checks if file exist and creates one if it doesn't
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

        //Exports bat file
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet");
        }

        //Loads a bat file
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet");
        }

        //Sends user to the GitHub page
        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/jonesy-b-dev/StartupAppBooter");
        }

        //Shows user the about window
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AppBooter \nVersion: 0.0.1 \nCopyright © 2022- 2022 Jonas de Bruin \n\nAppBooter is a app created by Jonas de Bruin and used to boot custom apps in bulk at any time. Currently in early development");
        }

        private void SelectAppBTN_Click(object sender, EventArgs e)
        {
            FileHandler.AddAppToGroup();       
        }
    }
}