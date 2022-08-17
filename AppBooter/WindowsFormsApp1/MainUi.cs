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
            MessageBox.Show("notepad will start now");
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = "../StartupAppBooter/AppBooter";
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            ExternalProcess.Start();
            ExternalProcess.WaitForExit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("D:/test.bat");
            //txt.Write(textBox1.Text);
            txt.WriteAsync(textBox1.Text);
            txt.Close();
        }
    }
}
