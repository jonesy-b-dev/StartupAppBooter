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
        static public void Save()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.Title = "Save a Text File";
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.FileName = "savedProgramms.txt";

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

                    MessageBox.Show("Your file has been saved to!");
                }
            }
        }

        static public void Load()
        {
            MessageBox.Show("This feature is not implemented yet");
        }

        static public void GitHub()
        {
            Process.Start("https://github.com/jonesy-b-dev/StartupAppBooter");
        }

        static public void About()
        {
            MessageBox.Show("AppBooter \nVersion: 0.0.1 \nCopyright © 2022- 2022 Jonas de Bruin \n\nAppBooter is a app created by Jonas de Bruin and used to boot custom apps in bulk at any time. Currently in early development.");
        }
    }
}
