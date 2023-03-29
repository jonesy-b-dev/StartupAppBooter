using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace WindowsFormsApp1
{
    internal class MenuStrip
    {
        //Saves a txt and writes all the selected apps to it
        static public void Save()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Text Files|*.txt",
                Title = "Save selected programs",
                InitialDirectory = @"C:\",
                FileName = "savedProgramms.txt"
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Open the file for writing
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (string app in AppHandler.appList)
                    {
                        writer.WriteLine(app);
                    }

                    writer.Close();

                    MessageBox.Show("Your file has been saved!");
                }
            }

        }

        //Loads a txt file and adds all the apps to the app list
        static public void Load(Label AppListPath)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Load selected programs",
                InitialDirectory = @"C:\",
                FileName = "savedProgramms.txt",
                Filter = "Text Files|*.txt"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                AppHandler.ClearAppList(AppListPath);
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                foreach (string line in lines)
                {
                    AppHandler.appList.Add(line);
                }
                AppListPath.Text = AppHandler.appListTemp;
                MessageBox.Show("Your apps has been successfully loaded!");
            }

        }

        static public void GitHub()
        {
            Process.Start("https://github.com/jonesy-b-dev/StartupAppBooter");
        }

        static public void About()
        {
            MessageBox.Show("AppBooter \nVersion: 0.0.2 \nCopyright © 2022- 2022 Jonas de Bruin \n\nAppBooter is a app created by Jonas de Bruin and used to boot custom apps in bulk at any time. Currently in early development.");
        }
    }
}
