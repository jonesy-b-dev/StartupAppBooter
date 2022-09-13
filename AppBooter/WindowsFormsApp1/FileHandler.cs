using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class FileHandler
    {
        static string pathList = "";
        static string exeList = "";

        static public void AddAppToList(TextBox pathField, TextBox exeField, Label AppListPath, Label AppListExe)
        {
            //Checks if textfields are empty
            if ((pathField.Text == "" || exeField.Text == "") || (pathField.Text == "" && exeField.Text == ""))
            {
                MessageBox.Show("There is a empty field");
            }
            else
            {
                if (File.Exists("ActualAppBooter.bat"))
                {
                    File.AppendAllText(@"ActualAppBooter.bat", "cd " + pathField.Text + "\n" + "start " + exeField.Text + Environment.NewLine);
                    pathList = pathList + pathField.Text + "\n";
                    exeList = exeList + exeField.Text + "\n";
                    AppListPath.Text = pathList;
                    AppListExe.Text = exeList;
                }
                else
                {
                    File.Create("ActualAppBooter.bat").Close();
                    File.AppendAllText(@"ActualAppBooter.bat", "cd " + pathField.Text + "\n" + "start " + exeField.Text + Environment.NewLine);
                    pathList = pathList + pathField.Text + "\n";
                    exeList = exeList + exeField.Text + "\n";
                    AppListPath.Text = pathList;
                    AppListExe.Text = exeList;
                }
                pathField.Clear();
                exeField.Clear();
            }
        }

        public static void ClearAppList(Label AppListPath, Label AppListExe)
        {
            TextWriter txt = new StreamWriter("ActualAppBooter.bat");
            txt.WriteAsync("");
            AppListPath.Text = "";
            AppListExe.Text = "";
            pathList = "";
            exeList = "";
            txt.Close();
        }
    }
}
