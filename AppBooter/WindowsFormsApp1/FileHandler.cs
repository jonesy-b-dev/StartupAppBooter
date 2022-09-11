using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class FileHandler
    {
        static public void AddAppToList(TextBox textBox2, TextBox exeField, Label AppListPath, Label AppListExe)
        {
            if ((textBox2.Text == "" || exeField.Text == "") || (textBox2.Text == "" && exeField.Text == ""))
            {
                MessageBox.Show("There is a empty field");
            }
            else
            {
                AddApp(textBox2.Text, exeField.Text, false, textBox2, exeField, AppListPath, AppListExe);
                textBox2.Clear();
                exeField.Clear();
            }
        }
        static string paths = "";
        static string exes = "";

        static void AddApp(string path, string exe, bool fromFile, TextBox textBox2, TextBox exeField, Label AppListPath, Label AppListExe)
        {
            if (File.Exists("ActualAppBooter.bat"))
            {
                File.AppendAllText(@"ActualAppBooter.bat", "cd " + path + "\n" + "start " + exe + Environment.NewLine);
                paths = paths + textBox2.Text + "\n";
                exes = exes + exeField.Text + "\n";
                AppListPath.Text = paths;
                AppListExe.Text = exes;
            }
            else
            {
                File.Create("ActualAppBooter.bat").Close();
                File.AppendAllText(@"ActualAppBooter.bat", "cd " + path + "\n" + "start " + exe + Environment.NewLine);
                paths = paths + textBox2.Text + "\n";
                exes = exes + exeField.Text + "\n";
                AppListPath.Text = paths;
                AppListExe.Text = exes;
            }
        }

        public static void ClearAppList(Label AppListPath, Label AppListExe)
        {
            TextWriter txt = new StreamWriter("ActualAppBooter.bat");
            txt.WriteAsync("");
            AppListPath.Text = "";
            AppListExe.Text = "";
            paths = "";
            exes = "";
            txt.Close();
        }
    }
}
