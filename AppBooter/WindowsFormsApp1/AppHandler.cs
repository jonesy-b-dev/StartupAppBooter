using System;
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
        static public string appListTemp;


        public static List<string> appList = new List<string>();

        static public void OpenFileDialog(Label pathField)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "exe files (*.exe)|*.exe";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file and add it to the list
                    appListTemp = "";
                    selectedApp = openFileDialog.FileName;
                    appList.Add(selectedApp);
                    appListTemp += selectedApp + "\n";
                    pathField.Text = appListTemp;
                }
            }
        }

        //Clears the whole app list
        public static void ClearAppList(Label AppListPath)
        {
            if (AppListPath.Text != "None")
            {
                appList.Clear();
                AppListPath.Text = "";
            }
        }

        //Run the apps
        public static void RunApps()
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
