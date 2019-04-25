using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_Manager
{
    [XmlType("Task")]
    public class Task
    {
        [XmlElement("TaskName")]
        public string Name { get; set; }

        [XmlElement("TaskDescription")]
        public string Description { get; set; }

        [XmlElement("TaskComplete")]
        public bool IsComplete { get; set; }

        [XmlArray("TaskItemsList")]
        [XmlArrayItem("TaskItemsListItem")]
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
