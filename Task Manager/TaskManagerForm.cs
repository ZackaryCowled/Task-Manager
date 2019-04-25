using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class TaskManagerForm : Form
    {
        public string ProjectFilepath { get; set; }

        public Project project;
        public TaskListControl taskListControl;
        public TaskControl taskControl;

        public TaskManagerForm()
        {
            InitializeComponent();
        }

        private void TaskManagerForm_Load(object sender, EventArgs e)
        {
            //Create project
            project = new Project();

            //Create and configure custom controls
            InitializeTaskListControl();
            InitializeTaskControl();
        }

        //Creates and configures the task list control
        private void InitializeTaskListControl()
        {
            taskListControl = new TaskListControl(project);
            taskListControl.Location = new Point(0, MenuStrip.ClientRectangle.Bottom);
            taskListControl.Size = new Size(taskListControl.Size.Width, ClientSize.Height - MenuStrip.Size.Height);
            taskListControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            taskListControl.Parent = this;
        }

        //Creates and configures the task control
        protected virtual void InitializeTaskControl()
        {
            taskControl = new TaskControl(project, taskListControl);
            taskControl.Location = new Point(taskListControl.ClientRectangle.Right, MenuStrip.ClientRectangle.Bottom);
            taskControl.Size = new Size(taskControl.Size.Width, ClientSize.Height - MenuStrip.Size.Height);
            taskControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            taskControl.Visible = false;
            taskControl.Parent = this;
        }

        //Opens a project of the users choosing
        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create and configure open file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Project File|*.xml";
            openFileDialog.Title = "Open Project";

            //Show open file dialog
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Update the project filepath
                ProjectFilepath = openFileDialog.FileName;
            }

            //If the project filepath is valid
            if (!string.IsNullOrEmpty(ProjectFilepath) && File.Exists(ProjectFilepath))
            {
                //Open the project
                project.Load(ProjectFilepath);
            }
        }

        //Saves the project
        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If the project filepath is not valid
            if(!File.Exists(ProjectFilepath))
            {
                //Create and configure save file dialog
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Project File|*.xml";
                saveFileDialog.Title = "Save Project";

                //Show save file dialog
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Update the project filepath
                    ProjectFilepath = saveFileDialog.FileName;
                }
            }

            //If the project filepath is valid
            if(!string.IsNullOrEmpty(ProjectFilepath))
            {
                //Save the project
                if (!project.Save(ProjectFilepath))
                {
                    //Display error message
                    MessageBox.Show("Failed to save project");
                }
            }
        }

        //Saves the project
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create and configure save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Project File|*.xml";
            saveFileDialog.Title = "Save Project";

            //Show save file dialog
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Update the project filepath
                ProjectFilepath = saveFileDialog.FileName;
            }

            //If the project filepath is valid
            if(!string.IsNullOrEmpty(ProjectFilepath))
            {
                //Save the project
                if(!project.Save(ProjectFilepath))
                {
                    //Display error message
                    MessageBox.Show("Failed to save project");
                }
            }
        }

        //Closes the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Creates a task
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //Removes the selected task
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
