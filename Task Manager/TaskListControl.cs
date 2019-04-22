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
    public partial class TaskListControl : UserControl
    {
        List<Task> tasks;

        public TaskListControl()
        {
            InitializeComponent();
        }

        //Initializes the task list control
        private void TaskListControl_Load(object sender, EventArgs e)
        {
            tasks = new List<Task>();
        }

        //Creates a task
        public void CreateTask()
        {
            //If no tasks exist
            if(TaskList.Items.Count == 0)
            {
                //Show the task control
                ShowTaskControl();
            }

            //Create and configure task
            Task task = new Task();
            tasks.Add(task);

            //Add task name to task list
            TaskList.Items.Add(task.Name);

            //Select task
            TaskList.SelectedIndex = TaskList.Items.Count - 1;
        }

        //Creates a task
        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            CreateTask();
        }

        //Removes the selected task
        public void RemoveSelectedTask()
        {
            //If at least one task exists
            if (TaskList.Items.Count > 0)
            {
                //Cache selected index
                int selectedIndex = TaskList.SelectedIndex;

                //Remove selected task
                tasks.RemoveAt(TaskList.SelectedIndex);
                TaskList.Items.RemoveAt(TaskList.SelectedIndex);

                //If at least one task still remains
                if (TaskList.Items.Count > 0)
                {
                    //If an item above the removed task can be selected
                    if (selectedIndex > 0)
                    {
                        //Select the above task
                        TaskList.SelectedIndex = selectedIndex - 1;
                    }
                    else
                    {
                        //Select the first task
                        TaskList.SelectedIndex = selectedIndex;
                    }
                }
                else
                {
                    //Hide the task control
                    HideTaskControl();
                }
            }
        }

        //Removes the selected task
        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedTask();
        }

        private void TaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If at least one task exists
            if (TaskList.SelectedIndex >= 0)
            {
                //Select the task using the task control
                ((TaskManagerForm)Parent).taskControl.SelectTask(tasks[TaskList.SelectedIndex]);
            }
        }

        //Shows the task control
        private void ShowTaskControl()
        {
            //If the task control is not visible
            if (!((TaskManagerForm)Parent).taskControl.Visible)
            {
                //Show the task control
                ((TaskManagerForm)Parent).taskControl.Visible = true;
            }
        }

        //Hides the task control
        private void HideTaskControl()
        {
            //If the task control is visible
            if (((TaskManagerForm)Parent).taskControl.Visible)
            {
                //Hide the task control
                ((TaskManagerForm)Parent).taskControl.Visible = false;
            }
        }

        //Sets the name of the selected task
        public void SetSelectedTaskName(string name)
        {
            tasks[TaskList.SelectedIndex].Name = name;
            TaskList.Items[TaskList.SelectedIndex] = name;
        }
    }
}

