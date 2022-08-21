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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "" || exeField.Text == "") || (textBox1.Text == "" && exeField.Text == ""))
            {
                MessageBox.Show("There is a empty field");
            }
            else
            {
                File.AppendAllText(@"D:/Code Projects/C#/StartupAppBooter/ActualAppBooter.bat", "cd " + textBox1.Text + "\n" + "start " + exeField.Text + Environment.NewLine);
                textBox1.Clear();
                exeField.Clear();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("D:/Code Projects/C#/StartupAppBooter/ActualAppBooter.bat");
            txt.WriteAsync("");
            txt.Close();
        }
    }
}
