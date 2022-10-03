using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class AppHandler
    {
        static string pathList = "";
        static string exeList = "";

        static public void OpenFileDialog()
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

        }
    }
}
