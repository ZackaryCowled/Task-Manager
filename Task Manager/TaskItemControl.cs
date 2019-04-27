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

        //Creates and initializes a task item control
        public TaskItemControl(Task task, TaskItem taskItem)
        {
            //Initialize task item control
            InitializeComponent();

            //Link with task and task item
            this.task = task;
            this.taskItem = taskItem;
        }

        //Called when the remove button is clicked
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //Remove the task item
            task.RemoveTaskItem(taskItem);
        }
    }
}
