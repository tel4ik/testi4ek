using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mvc.Model
{
    public class ToDoItem
    {
        public string Name { get; set; }
        public string Description { get; set; }  //  Описание задачи
        public string Status { get; set; }       //  Статус задачи
    }
}
