using System;
using System.Net.Configuration;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class MainUi : Form
    {
        //Create the object for the settings window
        readonly SettingsWindow settingsWindow = new SettingsWindow();
        
        public MainUi()
        {
            InitializeComponent();
            SettingsManager.LoadSettings(this, settingsWindow);
        }

        ~MainUi()
        {
            Settings.Default.Save();
        }

        #region App UI
        private void SelectAppBTN_Click(object sender, EventArgs e)
        {
            AppHandler.OpenFileDialog(AppListPath);
        }

        //Startup the programms button
        private void Button1_Click(object sender, EventArgs e)
        {
            AppHandler.RunApps();
        }

        //Clears all the apps from the boot list
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AppHandler.ClearAppList(AppListPath);
        }
        #endregion

        //Menu Strip
        #region File
        //Exports bat file
        private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuStrip.Save();
        }

        //Loads a bat file
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStrip.Load(AppListPath);
        }
        #endregion

        #region Help
        //Sends user to the GitHub page
        private void GitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStrip.GitHub();
        }

        //Shows user the about window
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStrip.About();
        }
        #endregion

        #region Tools
        private void DarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsManager.DarkTheme(this, settingsWindow);
        }

        private void LightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsManager.LightTheme(this, settingsWindow);
        }


        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsWindow.Show();
        }
        #endregion
    }
}