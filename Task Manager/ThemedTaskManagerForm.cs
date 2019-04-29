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
    public partial class ThemedTaskManagerForm : TaskManagerForm
    {
        //Creates and initializes a themed task manager form
        public ThemedTaskManagerForm()
        {
            //Initialize
            InitializeComponent();

            //Enforce minimum size
            MinimumSize = new Size(Width, Height);
        }

        //Creates and configures the task control
        protected override void InitializeTaskControl()
        {
            taskControl = new TaskControl(project, taskListControl, true);
            taskControl.Location = new Point(taskListControl.ClientRectangle.Right, MenuStrip.Size.Height + ThemeLabel.Size.Height + 6);
            taskControl.Size = new Size(taskControl.Size.Width, ClientSize.Height - MenuStrip.Size.Height - ThemeLabel.Size.Height - 6);
            taskControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            taskControl.Visible = false;
            taskControl.Parent = this;
        }
    }
}
