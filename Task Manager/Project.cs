using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_Manager
{
    [XmlRoot("Project")]
    [XmlInclude(typeof(Task))]
    public class Project
    {
        [XmlArray("TaskList")]
        [XmlArrayItem("TaskListItem")]
        public List<Task> Tasks = new List<Task>();
    }
}
