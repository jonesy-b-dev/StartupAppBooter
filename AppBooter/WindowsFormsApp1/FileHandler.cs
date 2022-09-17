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
                //Checks if file exist and creates one if it doesn't exist
                if (File.Exists("ActualAppBooter.bat"))
                {
                    //Add app path and exe to the bat file
                    File.AppendAllText(@"ActualAppBooter.bat", "cd " + pathField.Text + "\n" + "start " + exeField.Text + Environment.NewLine);
                    //Add app path and exe to the UI list
                    pathList = pathList + pathField.Text + "\n";
                    exeList = exeList + exeField.Text + "\n";
                    AppListPath.Text = pathList;
                    AppListExe.Text = exeList;
                }
                else
                {
                    File.Create("ActualAppBooter.bat").Close();
                    //Add app path and exe to the bat file
                    File.AppendAllText(@"ActualAppBooter.bat", "cd " + pathField.Text + "\n" + "start " + exeField.Text + Environment.NewLine);
                    //Add app path and exe to the UI list
                    pathList = pathList + pathField.Text + "\n";
                    exeList = exeList + exeField.Text + "\n";
                    AppListPath.Text = pathList;
                    AppListExe.Text = exeList;
                }
                //Clears the input fields
                pathField.Clear();
                exeField.Clear();
            }
        }

        static public void AddAppToGroup()
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
                    pathList = openFileDialog.FileName;

                }
            }
        }

        //Clears the whole bat file
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
