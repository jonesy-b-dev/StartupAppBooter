using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class MainStart
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainUi());
        }
    }
}
