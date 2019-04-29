using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Manager.TaskItems;

namespace Task_Manager
{
    public partial class TaskControl : UserControl
    {
        private Project project;
        private Task selectedTask;
        private TaskListControl taskListControl;
        private TaskItemPanelControl taskItemPanel;

        //Initializes and sets up the task control
        public TaskControl(Project project, TaskListControl taskListControl)
        {
            //Initialize the task control
            InitializeComponent();

            //Link with the specified project
            this.project = project;
            
            //Link with the specified task list control
            this.taskListControl = taskListControl;
            this.taskListControl.OnTaskSelected += ReloadTask;
        }

        //Creates and configures custom controls
        private void TaskControl_Load(object sender, EventArgs e)
        {
            //Create and configure custom controls
            InitializeTaskItemPanelControl();
        }

        //Initializes the task item panel control
        private void InitializeTaskItemPanelControl()
        {
            //Initialize the task item panel control
            taskItemPanel = new TaskItemPanelControl(this);
            taskItemPanel.Location = new Point(0, DescriptionTextbox.Location.Y + DescriptionTextbox.Size.Height);
            taskItemPanel.AutoScroll = true;
            taskItemPanel.Parent = this;
        }

        //Releases currently loaded task items and loads the specified task
        private void ReloadTask(Task task)
        {
            //If the selected task is valid
            if(selectedTask != null)
            {
                //Unsubscribe from the selected tasks events
                selectedTask.OnTaskItemAdded -= OnTaskItemAdded;
                selectedTask.OnTaskItemRemoved -= OnTaskItemRemoved;
            }

            //Link with the specified task
            selectedTask = task;
            selectedTask.OnTaskItemAdded += OnTaskItemAdded;
            selectedTask.OnTaskItemRemoved += OnTaskItemRemoved;

            //Load basic task information
            NameTextbox.Text = selectedTask.Name;
            CompleteCheckbox.Checked = selectedTask.IsComplete;
            DescriptionTextbox.Text = selectedTask.Description;

            //Release currently loaded task items
            taskItemPanel.RemoveAllTaskItems();

            //For each task item in the selected task
            foreach(TaskItem taskItem in selectedTask.Items)
            {
                //Add task item control to the task item panel
                taskItemPanel.AddTaskItem(new TaskItemControl(selectedTask, taskItem));
            }
        }

        //Called when a task item is added to the selected task
        private void OnTaskItemAdded(TaskItem taskItem)
        {
            //Add the task item control to the task item panel
            taskItemPanel.AddTaskItem(new TaskItemControl(selectedTask, taskItem));
        }

        //Called when a task item is removed from the selected task
        private void OnTaskItemRemoved(int index)
        {
            //Remove the task item control at the specified index in the task item panel
            taskItemPanel.RemoveTaskItem(index);
        }

        //Called when the name textbox text changes
        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            //Update the selected tasks name
            taskListControl.SetSelectedTasksName(NameTextbox.Text);
        }

        //Called when the complete checkbox checked state changes
        private void CompleteCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //Update the selected tasks is complete flag
            selectedTask.IsComplete = CompleteCheckbox.Checked;
        }

        //Called when the description textbox text changes
        private void DescriptionTextbox_TextChanged(object sender, EventArgs e)
        {
            //Update the selected tasks description
            selectedTask.Description = DescriptionTextbox.Text;
        }

        //Called when the add task item button is clicked
        private void AddTaskItemButton_Click(object sender, EventArgs e)
        {
            //TODO: Select from all custom task items
            //Add a task item to the selected task
            selectedTask.AddTaskItem<DifficultyTaskItem>();
        }
    }
}
