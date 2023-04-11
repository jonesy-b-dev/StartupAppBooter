using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    internal static class SettingsManager
    {
        public static void LoadSettings(MainUi ui, SettingsWindow settingUi)
        {
            if (Settings.Default.darkTheme == true)
            {
                DarkTheme(ui, settingUi);
                settingUi.ThemeCombo.SelectedIndex = 0;
            }
            else
            {
                LightTheme(ui, settingUi);
                settingUi.ThemeCombo.SelectedIndex = 1;
            }

            if (Settings.Default.RestoreDir)
            {
                settingUi.RestoreDirCB.Checked = true;
            }
            else
            {
                settingUi.RestoreDirCB.Checked = false;
            }
        }

        internal static void RestoreDir(CheckBox restoreDirCB)
        {
            if (restoreDirCB.Checked)
            {
                Settings.Default.RestoreDir = true;
            }
            else
            {
                Settings.Default.RestoreDir = false;
                Settings.Default.selectDir = @"C:\";
            }
            
            Settings.Default.Save();
        }

        internal static void DarkTheme(MainUi ui, SettingsWindow settingUI)
        {
            ui.MenuBar.Renderer = new DarkThemeRenderer();

            Settings.Default.darkTheme = true;
            Settings.Default.Save();

            //Menu Strip
            ui.MenuBar.BackColor = Color.FromArgb(20, 20, 20);
            ui.MenuBar.ForeColor = Color.White;
            ui.fileToolStripMenuItem1.BackColor = Color.FromArgb(20, 20, 20);
            ui.fileToolStripMenuItem1.ForeColor = Color.White;
            ui.saveToolStripMenuItem1.ForeColor = Color.White;
            ui.loadToolStripMenuItem.ForeColor = Color.White;
            ui.gitHubToolStripMenuItem.ForeColor = Color.White;
            ui.aboutToolStripMenuItem.ForeColor = Color.White;
            ui.themeToolStripMenuItem.ForeColor = Color.White;
            ui.darkToolStripMenuItem.ForeColor = Color.White;
            ui.lightToolStripMenuItem.ForeColor = Color.White;
            ui.settingsToolStripMenuItem.ForeColor = Color.White;

            //General UI
            ui.BackColor = Color.FromArgb(50, 50, 50);
            ui.label1.ForeColor = Color.White;
            ui.AddedAppsList.ForeColor = Color.White;
            ui.PathLabel.ForeColor = Color.White;
            ui.AppListPath.ForeColor = Color.White;

            //Settings UI
            settingUI.BackColor = Color.FromArgb(50, 50, 50);
            settingUI.ForeColor = Color.White;
        }

        internal static void LightTheme(MainUi ui, SettingsWindow settingUI)
        {
            ui.MenuBar.Renderer = new LightThemeRenderer();

            Settings.Default.darkTheme = false;
            Settings.Default.Save();

            //Menu Strip
            ui.MenuBar.BackColor = Color.White;
            ui.MenuBar.ForeColor = Color.Black;
            ui.fileToolStripMenuItem1.BackColor = Color.White;
            ui.fileToolStripMenuItem1.ForeColor = Color.Black;
            ui.saveToolStripMenuItem1.ForeColor = Color.Black;
            ui.loadToolStripMenuItem.ForeColor = Color.Black;
            ui.gitHubToolStripMenuItem.ForeColor = Color.Black;
            ui.aboutToolStripMenuItem.ForeColor = Color.Black;
            ui.themeToolStripMenuItem.ForeColor = Color.Black;
            ui.darkToolStripMenuItem.ForeColor = Color.Black;
            ui.lightToolStripMenuItem.ForeColor = Color.Black;
            ui.settingsToolStripMenuItem.ForeColor = Color.Black;

            //General UI
            ui.BackColor = Color.FromArgb(240, 240, 240);
            ui.label1.ForeColor = Color.Black;
            ui.AddedAppsList.ForeColor = Color.Black;
            ui.PathLabel.ForeColor = Color.Black;
            ui.AppListPath.ForeColor = Color.Black;

            //Settings UI
            settingUI.BackColor = Color.White;
            settingUI.ForeColor = Color.Black;
        }
    }

    //Menu renderer overwrite
    internal class DarkThemeRenderer : ToolStripProfessionalRenderer
    {
        public DarkThemeRenderer() : base(new DarkTheme()) { }
    }

    public class DarkTheme : ProfessionalColorTable
    {
        // Gets the starting color of the gradient used when 
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(30, 30, 30);

        // Gets the end color of the gradient used when a top-level 
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(30, 30, 30);

        // Gets the solid background color of the 
        public override Color ToolStripDropDownBackground => Color.FromArgb(30, 30, 30);

        // Gets the starting color of the gradient used in the //image 
        public override Color ImageMarginGradientBegin => Color.FromArgb(40, 40, 40);

        // Gets the middle color of the gradient used in the //image 
        public override Color ImageMarginGradientMiddle => Color.FromArgb(40, 40, 30);

        // Gets the end color of the gradient used in the image 
        public override Color ImageMarginGradientEnd => Color.FromArgb(40, 40, 40);
    }

    internal class LightThemeRenderer : ToolStripProfessionalRenderer
    {
        public LightThemeRenderer() : base(new LightTheme()) { }
    }

    public class LightTheme : ProfessionalColorTable
    {
        // Gets the starting color of the gradient used when 
        public override Color MenuItemPressedGradientBegin => default;

        // Gets the end color of the gradient used when a top-level 
        public override Color MenuItemPressedGradientEnd => default;

        // Gets the solid background color of the 
        public override Color ToolStripDropDownBackground => default;

        // Gets the starting color of the gradient used in the //image 
        public override Color ImageMarginGradientBegin => default;

        // Gets the middle color of the gradient used in the //image 
        public override Color ImageMarginGradientMiddle => default;

        // Gets the end color of the gradient used in the image 
        public override Color ImageMarginGradientEnd => default;
    }
}