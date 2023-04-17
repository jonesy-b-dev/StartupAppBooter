using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    internal class GroupManger
    {
        public static List<string> groupList = new List<string>();
        public static List<string> groupListTemp = new List<string>();
        public static string selectedGroup = "";
        public static string selectedGroupTemp = "";

        public static void AddGroup(string groupName)
        {
            groupList.Add(groupName);
            groupListTemp.Add(groupName);
        }
        public static void RemoveGroup(string groupName)
        {
            groupList.Remove(groupName);
            groupListTemp.Remove(groupName);
        }
        public static void ClearGroupList()
        {
            groupList.Clear();
            groupListTemp.Clear();
        }
        public static void SelectGroup(string groupName)
        {
            selectedGroup = groupName;
            selectedGroupTemp = groupName;
        }
        public static void ClearSelectedGroup()
        {
            selectedGroup = "";
            selectedGroupTemp = "";
        }
    }
}
