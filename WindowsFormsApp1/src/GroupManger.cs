using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp
{
	internal class GroupManger
	{
		public static List<string> groupList = new List<string>();
		public static List<string> groupData = new List<string>();
		public static string selectedGroup = "";
		public static string selectedGroupTemp = "";

		public static void AddGroup(string groupName, MainUi mainUI)
		{
			groupList.Add(groupName);
            mainUI.Groups.Items.Add(groupName);

        }
		public static void RemoveGroup(string groupName)
		{
			groupList.Remove(groupName);
		}
		public static void ClearGroupList()
		{
			groupList.Clear();
		}
		public static void SelectGroup(string groupName)
		{
			selectedGroup = groupName;
		}
		public static void ClearSelectedGroup()
		{
			selectedGroup = "";
		}
	}
}
