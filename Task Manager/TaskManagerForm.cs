using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class TaskManagerForm : Form
    {
        public TaskListControl taskListControl;
        public TaskControl taskControl;

        public TaskManagerForm()
        {
            InitializeComponent();
        }

        private void TaskManagerForm_Load(object sender, EventArgs e)
        {
            //Create and configure custom controls
            InitializeTaskListControl();
            InitializeTaskControl();
        }

        //Creates and configures the task list control
        private void InitializeTaskListControl()
        {
            taskListControl = new TaskListControl();
            taskListControl.Location = new Point(0, MenuStrip.ClientRectangle.Bottom);
            taskListControl.Size = new Size(taskListControl.Size.Width, ClientSize.Height - MenuStrip.Size.Height);
            taskListControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            taskListControl.Parent = this;
        }

        //Creates and configures the task control
        protected virtual void InitializeTaskControl()
        {
            taskControl = new TaskControl();
            taskControl.Location = new Point(taskListControl.ClientRectangle.Right, MenuStrip.ClientRectangle.Bottom);
            taskControl.Size = new Size(taskControl.Size.Width, ClientSize.Height - MenuStrip.Size.Height);
            taskControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            taskControl.Visible = false;
            taskControl.Parent = this;
        }

        //Closes the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Creates a task
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskListControl.CreateTask();
        }

        //Removes the selected task
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskListControl.RemoveSelectedTask();
        }
    }
}
