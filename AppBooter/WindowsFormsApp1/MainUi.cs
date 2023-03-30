using System;
using System.Drawing;
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
            this.MenuBar.Renderer = new CustomMenuStripRenderer();
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

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DarkTheme();
        }

        private void DarkTheme()
        {
            Settings.Default.darkTheme = true;
            Settings.Default.Save();
            
            MenuBar.BackColor = Color.FromArgb(20, 20, 20);
            MenuBar.ForeColor = Color.White;
            fileToolStripMenuItem1.BackColor = Color.FromArgb(20, 20, 20);


            BackColor = Color.FromArgb(50, 50, 50);
            label1.ForeColor = Color.White;
            AddedAppsList.ForeColor = Color.White;
            PathLabel.ForeColor = Color.White;
            AppListPath.ForeColor = Color.White;
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LightTheme();
        }

        private void LightTheme()
        {
            Settings.Default.darkTheme = false;
            Settings.Default.Save();

            BackColor = DefaultBackColor;
            label1.ForeColor = DefaultForeColor;
            AddedAppsList.ForeColor = DefaultForeColor;
            PathLabel.ForeColor = DefaultForeColor;
            AppListPath.ForeColor = DefaultForeColor;
        }

        private void LoadSettings()
        {
            AddedAppsList.Text = "Loaded";
            if (Settings.Default.darkTheme == true)
            {
                DarkTheme();
            }
            else
            {
                LightTheme();
            }
        }
    }

    
}