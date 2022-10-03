﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class AppHandler
    {
        static string selectedApp = "";

        static List<string> appList = new List<string>();

        static public void OpenFileDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "exe files (*.exe)|*.exe";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    selectedApp = openFileDialog.FileName;
                    appList.Add(selectedApp);
                }
            }
        }

        //Clears the whole bat file
        public static void ClearAppList(Label AppListPath, Label AppListExe)
        {
            appList.Clear();
        }

        //Run the apps
        public static void runApps()
        {
            Process runAppsP = new Process();

            foreach (string app in appList)
            {
                runAppsP.StartInfo.FileName = app;
                runAppsP.Start();
            }
        }
    }
}