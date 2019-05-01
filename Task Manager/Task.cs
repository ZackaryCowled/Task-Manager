using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Task_Manager.TaskItems;

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

        public delegate void TaskItemAddedEvent(TaskItem taskItem);
        public event TaskItemAddedEvent OnTaskItemAdded;

        public delegate void TaskItemRemovedEvent(int index);
        public event TaskItemRemovedEvent OnTaskItemRemoved;

        //Initializes a task
        public Task()
        {
            Name = "Untitled";
            Description = "";
            IsComplete = false;
            Items = new List<TaskItem>();
        }

        //Adds a new task item to the task
        //Invokes the task item added event
        //Returns the newly created task item
        public TaskItem AddTaskItem(Type taskItemType)
        {
            //Add task item to the items list
            Items.Add((TaskItem)Activator.CreateInstance(taskItemType));

            //If at least one subscription to the on task item added event exists
            if(OnTaskItemAdded != null)
            {
                //Invoke the on task item added event
                OnTaskItemAdded.Invoke(Items.Last());
            }

            //Return the task item
            return (TaskItem)Items.Last();
        }

        //Removes the task item at the specified index in the task
        //Invokes the task item removed event
        //Returns a flag indicating whether the task item was removed successfully
        public bool RemoveTaskItem(int index)
        {
            //If the specified index is inside the bounds of the items list
            if(index >= 0 && index < Items.Count)
            {
                //Remove the task item at the specified index in the items list
                Items.RemoveAt(index);

                //If at least one subscription to the on task item removed event exists
                if(OnTaskItemRemoved != null)
                {
                    //Invoke the on task item removed event
                    OnTaskItemRemoved.Invoke(index);
                }

                //Successfully removed task item
                return true;
            }

            //Failed to remove task item
            return false;
        }

        //Removes the specified task item from the task
        //Invokes the task item removed event
        //Returns a flag indicating whether the task item was removed successfully
        public bool RemoveTaskItem(TaskItem taskItem)
        {
            //Find the index of the specified task item
            int index = Items.IndexOf(taskItem);

            //Remove the task item
            return RemoveTaskItem(index);
        }
    }
}
