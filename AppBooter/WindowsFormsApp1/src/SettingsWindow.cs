using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SettingsWindow : Form
    {
        readonly MainUi m_mainUI;

        public SettingsWindow(MainUi mainUi)
        {
            m_mainUI = mainUi;
            InitializeComponent();
        }


        //Hides the settings window instead of closing it
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void ThemeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ThemeCombo.SelectedIndex == 0)
            {
                SettingsManager.DarkTheme(m_mainUI, this);
            }
            else if (ThemeCombo.SelectedIndex == 1)
            {
                SettingsManager.LightTheme(m_mainUI, this);
            }
        }
    }
}
