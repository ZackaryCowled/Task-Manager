using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public List<TaskItem> Items;

        public Task()
        {
            Name = "Untitled";
            Description = "";
            IsComplete = false;
            Items = new List<TaskItem>();
        }
    }
}
