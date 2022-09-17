using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class MenuStrip
    {
        static public void Save()
        {
            MessageBox.Show("This feature is not implemented yet");
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
            MessageBox.Show("AppBooter \nVersion: 0.0.1 \nCopyright © 2022- 2022 Jonas de Bruin \n\nAppBooter is a app created by Jonas de Bruin and used to boot custom apps in bulk at any time. Currently in early development");
        }
    }
}
