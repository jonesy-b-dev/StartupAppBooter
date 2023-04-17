using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp
{
	public partial class AddGroupWindow : Form
	{
        private string groupName = "";
        MainUi mainUi;
        
        public AddGroupWindow(MainUi mainUi)
		{
			InitializeComponent();
            this.mainUi = mainUi;
        }

		private void GroupNameTxtBox_TextChanged(object sender, EventArgs e)
		{
            groupName = GroupNameTxtBox.Text;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            GroupManger.AddGroup(groupName, mainUi);
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            groupName = "";
            this.Close();
        }
    }
}
