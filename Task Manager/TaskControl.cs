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
    public partial class TaskControl : UserControl
    {
        TaskItemPanelControl taskItemPanel;

        public TaskControl()
        {
            InitializeComponent();
        }

        private void TaskControl_Load(object sender, EventArgs e)
        {
            //Create and configure custom controls
            InitializeTaskItemPanelControl();
        }

        //Creates and configure the task item panel
        private void InitializeTaskItemPanelControl()
        {
            taskItemPanel = new TaskItemPanelControl();
            taskItemPanel.Location = new Point(0, DescriptionTextbox.Location.Y + DescriptionTextbox.Size.Height);
            taskItemPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            taskItemPanel.AutoScroll = true;
            taskItemPanel.Parent = this;
        }

        //Adds the task item to the task item panel
        public void AddTaskItem(TaskItemControl taskItem)
        {
            taskItemPanel.AddTaskItem(taskItem);
        }
    }
}
