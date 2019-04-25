using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class TaskItemPanelControl : UserControl
    {
        List<TaskItemControl> taskItems;

        public TaskItemPanelControl()
        {
            InitializeComponent();
        }

        private void TaskItemPanelControl_Load(object sender, EventArgs e)
        {
            //Initialize task items list
            taskItems = new List<TaskItemControl>();
        }

        //Adds the task item
        public void AddTaskItem(TaskItemControl taskItem)
        {
            //If at least one task item already exists
            if (taskItems.Count > 0)
            {
                //Configure task item location
                TaskItemControl lastTaskItem = taskItems[taskItems.Count - 1];
                taskItem.Location = new Point(0, lastTaskItem.Location.Y + lastTaskItem.Size.Height);
            }
            else
            {
                //Configure task item location
                taskItem.Location = new Point(0, 0);
            }

            //Configure task item size
            taskItem.Size = new Size(VerticalScroll.Enabled ? ClientRectangle.Width - SystemInformation.VerticalScrollBarWidth : ClientRectangle.Width, taskItem.Size.Height);

            //Add the task item
            taskItem.Parent = this;
            taskItems.Add(taskItem);
        }

        //Removes the task item
        public void RemoveTaskItem(TaskItemControl taskItem)
        {
            //Find the index of the task item
            int index = taskItems.IndexOf(taskItem);

            //If the task item is in the panel
            if (index > -1)
            {
                //For each task item after the specified task item
                for (int i = taskItems.Count - 1; i > index; i--)
                {
                    //Move task item up
                    taskItems[i].Location = taskItems[i - 1].Location;
                }

                //Remove the specified task item
                taskItems.Remove(taskItem);
                Controls.Remove(taskItem);
            }
        }

        //Removes all the task items
        public void RemoveAllTaskItems()
        {
            //If task items exist
            if (taskItems != null)
            {
                //Remove all task items
                taskItems.Clear();
                Controls.Clear();
            }
        }
    }
}

