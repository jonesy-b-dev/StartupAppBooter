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
        
        public void GetSettings()
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            label1.Text = "joe";
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
            MenuStrip.Save();
        }

        //Loads a bat file
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStrip.Load();
        }

        //Sends user to the GitHub page
        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStrip.GitHub();
        }

        //Shows user the about window
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStrip.About();
        }

        private void SelectAppBTN_Click(object sender, EventArgs e)
        {
            FileHandler.OpenFileDialog();       
        }
    }
}