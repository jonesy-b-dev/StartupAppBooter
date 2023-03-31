using System;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class MainUi : Form
    {
        public MainUi()
        {
            InitializeComponent();
            LoadSettings();
        }

        ~MainUi()
        {
            Settings.Default.Save();
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
        private void Button1_Click(object sender, EventArgs e)
        {
            AppHandler.RunApps();
        }

        //Clears all the apps from the boot list
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AppHandler.ClearAppList(AppListPath);
        }

        //Menu toolbar

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

        private void DarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsManager.DarkTheme(this);
        }

        private void LightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsManager.LightTheme(this);
        }

        private void LoadSettings()
        {
            AddedAppsList.Text = "Loaded";
            if (Settings.Default.darkTheme == true)
            {
                SettingsManager.DarkTheme(this);
            }
            else
            {
                SettingsManager.LightTheme(this);
            }
        }
    }
}