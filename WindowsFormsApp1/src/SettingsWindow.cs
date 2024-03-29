﻿using System;
using System.Windows.Forms;
using WindowsFormsApp;

namespace WindowsFormsApp1
{
    public partial class SettingsWindow : Form
    {
        readonly MainUi m_mainUI;
        readonly AddGroupWindow m_addGroupWindow;

        public SettingsWindow(MainUi mainUi, AddGroupWindow addGroupWindow)
        {
            m_mainUI = mainUi;
            m_addGroupWindow = addGroupWindow;
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
                SettingsManager.DarkTheme(m_mainUI, this, m_addGroupWindow);
            }
            else if (ThemeCombo.SelectedIndex == 1)
            {
                SettingsManager.LightTheme(m_mainUI, this, m_addGroupWindow);
            }
        }

        private void RestoreDirCB_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.RestoreDir(RestoreDirCB);
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
