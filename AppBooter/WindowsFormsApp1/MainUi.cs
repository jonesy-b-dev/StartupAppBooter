using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainUi : Form
    {
        public MainUi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = "D:/Code Projects/C#/StartupAppBooter/AppBooter";
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            ExternalProcess.Start();
            ExternalProcess.WaitForExit();
        }

        string paths;
        string exes;

        private void Add_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "" || exeField.Text == "") || (textBox2.Text == "" && exeField.Text == ""))
            {
                MessageBox.Show("There is a empty field");
            }
            else
            {
                AddApp(textBox2.Text, exeField.Text, false);
                textBox2.Clear();
                exeField.Clear();
            }
        }

        //Clears all the apps from the boot list
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("D:/Code Projects/C#/StartupAppBooter/ActualAppBooter.bat");
            txt.WriteAsync("");
            AppListPath.Text = "";
            AppListExe.Text = "";
            paths = "";
            exes = "";
            txt.Close();
        }

        void AddApp(string path, string exe, bool fromFile)
        {
            File.AppendAllText(@"D:/Code Projects/C#/StartupAppBooter/ActualAppBooter.bat", "cd " + path + "\n" + "start " + exe + Environment.NewLine);
            paths = paths + textBox2.Text + "\n";
            exes = exes + exeField.Text + "\n";
            AppListPath.Text = paths;
            AppListExe.Text = exes;
        }
    }
}