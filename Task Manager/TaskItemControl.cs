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
    public partial class TaskItemControl : UserControl
    {
        protected Task task;
        protected TaskItem taskItem;

        //Creates and initializes the task item control
        public TaskItemControl(Task task, TaskItem taskItem)
        {
            //Initialize task item control
            InitializeComponent();
            Initialize(task, taskItem);
        }

        //Initializes the task item control
        //Links the task item control with the task and task item
        //Decorates the task item control
        protected void Initialize(Task task, TaskItem taskItem)
        {
            //Link the task item control with the task and task item
            Link(task, taskItem);

            //Decorate the task item control
            Decorate();
        }

        //Links the task item control with the task and task item
        private void Link(Task task, TaskItem taskItem)
        {
            //Link with task and task item
            this.task = task;
            this.taskItem = taskItem;
        }

        //Decorates the task item control
        private void Decorate()
        {
            //Decorate the task item control
            taskItem.Decorate(this);
        }

        //Called when the remove button is clicked
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //Remove the task item
            task.RemoveTaskItem(taskItem);
        }
    }
}
