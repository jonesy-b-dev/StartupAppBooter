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

        }

        private void SelectAppBTN_Click(object sender, EventArgs e)
        {
            AppHandler.OpenFileDialog(AppListPath);       
        }

        //Startup the programms button
        private void button1_Click(object sender, EventArgs e)
        {
            AppHandler.runApps();
        }

        //Clears all the apps from the boot list
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AppHandler.ClearAppList(AppListPath);
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

        
    }
}