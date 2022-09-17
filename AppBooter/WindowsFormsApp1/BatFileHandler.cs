using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class BatFileHandler
    {
        static public void StartUpApps()
        {
            try
            {
                Process ExternalProcess = new Process();
                ExternalProcess.StartInfo.FileName = "ActualAppBooter.bat";
                ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                ExternalProcess.Start();
                ExternalProcess.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
