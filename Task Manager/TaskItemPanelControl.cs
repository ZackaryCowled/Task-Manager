﻿using System;
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
        TaskControl taskControl;
        List<TaskItemControl> taskItems;

        //Creates and initializes a task item panel control
        public TaskItemPanelControl(TaskControl taskControl)
        {
            //Initializes task item panel control components
            InitializeComponent();

            //Link with the task control
            Link(taskControl);
        }

        //Links the task control and subscribes to events
        private void Link(TaskControl taskControl)
        {
            //Link and subscribe to events
            this.taskControl = taskControl;
            this.taskControl.Resize += OnResize;
        }

        //Resizes the task item panel and children
        private void OnResize(object sender, EventArgs e)
        {
            //Resize task item panel control
            Size = new Size(taskControl.Width, Size.Height);

            //For each task item
            foreach(TaskItemControl taskItem in taskItems)
            {
                //Resize to fit the task item panel control
                taskItem.Size = new Size(Width - SystemInformation.VerticalScrollBarWidth, taskItem.Size.Height);
            }
        }

        //Called on load
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

        //Removes the task item at the specified index
        public void RemoveTaskItem(int index)
        {
            //If the index is inside the bounds of the task items list
            if(index >= 0 && index < taskItems.Count)
            {
                //For each task item after the specified index going from the end to the index
                for (int i = taskItems.Count - 1; i > index; i--)
                {
                    //Move task item up
                    taskItems[i].Location = taskItems[i - 1].Location;
                }

                //Removes the specified task item
                taskItems.RemoveAt(index);
                Controls.RemoveAt(index);
            }
        }

        //Removes the task item
        public void RemoveTaskItem(TaskItemControl taskItem)
        {
            //Find the index of the task item
            int index = taskItems.IndexOf(taskItem);

            //Remove the task item
            RemoveTaskItem(index);
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

