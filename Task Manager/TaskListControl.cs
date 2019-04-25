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
        public delegate void TaskSelectedEvent(Task task);
        public event TaskSelectedEvent OnTaskSelected;

        private Project project;

        //Initializes and sets up the task list control
        public TaskListControl(Project project)
        {
            //Initialize task list control
            InitializeComponent();

            //Link with the specified project
            this.project = project;
            this.project.OnProjectLoaded += ReloadTasks;
            this.project.OnTaskAdded += AddTask;
            this.project.OnTaskRemoved += RemoveTask;
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

        //Releases currently loaded tasks and loads the specified project
        private void ReloadTasks(Project project)
        {
            //Release currently loaded tasks
            TaskList.Items.Clear();

            //If there is at least one task in the project
            if (project.Tasks.Count > 0)
            {
                //Show the task control
                ShowTaskControl();

                //For each task in the project
                foreach (Task task in project.Tasks)
                {
                    //Add task
                    TaskList.Items.Add(task.Name);
                }
            }
            else
            {
                //Hide the task control
                HideTaskControl();
            }
        }

        //Adds the specified task to the task list
        private void AddTask(Task task)
        {
            //If no tasks exist
            if(TaskList.Items.Count == 0)
            {
                //Show the task control
                ShowTaskControl();
            }

            //Add the task to the task list
            TaskList.Items.Add(task.Name);

            //Select the task
            TaskList.SelectedIndex = TaskList.Items.Count - 1;
        }

        //Removes the task at the specified index in the task list
        private void RemoveTask(int index)
        {
            //Remove the task from the task list
            TaskList.Items.RemoveAt(index);

            //Select previous index
            SelectPreviousIndex(index);

            //If no tasks exist
            if(TaskList.Items.Count == 0)
            {
                //Hide the task control
                HideTaskControl();
            }
        }

        //Selects the previous index or current depending on the number of tasks available
        //NOTE: Should only be called after removing a task
        private void SelectPreviousIndex(int index)
        {
            //If at least one task exists
            if (TaskList.Items.Count > 0)
            {
                //If the index is not the first task
                if (index > 0)
                {
                    //Select the previous task
                    TaskList.SelectedIndex = index - 1;
                }
                else
                {
                    //Select the first task
                    TaskList.SelectedIndex = 0;
                }
            }
        }

        //Sets the name of the selected task to the specified name
        public void SetSelectedTasksName(string name)
        {
            //Set the name of the selected task to the specified name
            project.Tasks[TaskList.SelectedIndex].Name = name;
            TaskList.Items[TaskList.SelectedIndex] = name;
        }

        //Creates a new task
        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            //Create a new task
            project.AddTask();
        }

        //Removes the selected task
        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            //If at least one task exists
            if (TaskList.Items.Count > 0)
            {
                //Remove the selected task
                project.RemoveTask(TaskList.SelectedIndex);
            }
        }

        //Called when the task selection index changes
        private void TaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If at least one subscription to the on task selected event exists
            if(OnTaskSelected != null)
            {
                //If the selected index is valid
                if (TaskList.SelectedIndex >= 0 && TaskList.SelectedIndex < project.Tasks.Count)
                {
                    //Invoke the on task selected event
                    OnTaskSelected(project.Tasks[TaskList.SelectedIndex]);
                }
            }
        }
    }
}
