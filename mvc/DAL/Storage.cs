using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mvc.Model;


namespace mvc.DAL
{
    public static class Storage
    {
        public static List<ToDoItem> Items { get; set; }
        public static List<string> Statues { get; set; }

        static Storage()
        {
            Items = new List<ToDoItem>();

            Statues = new List<string>{
                "Новое", "В работе", "Завершена", "Отмена"};


            Items.Add(new ToDoItem
            {
                Name = "Test",
                Description = "TEST",
                Status = Statues[0],
            });

        }






    }
}
