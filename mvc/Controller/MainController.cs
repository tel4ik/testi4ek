using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mvc.Model;
using mvc.DAL;


namespace mvc.Controller
{
    public static class MainController
    {
        public static List<string> GetStatues()
        {
            return Storage.Statues;
        }


        public static List<ToDoItem> GetItems()
        {
            return Storage.Items;
        }

        public static void AddItems(ToDoItem item)
        {
            Storage.Items.Add(item);
        }

        public static void DeleteItems(ToDoItem item)
        {
            Storage.Items.Remove(item);
        }

    }
}
