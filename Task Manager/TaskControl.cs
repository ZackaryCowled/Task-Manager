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
    public partial class TaskControl : UserControl
    {
        TaskItemPanelControl taskItemPanel;
        Task selectedTask;

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

        //Selected the specified task
        public void SelectTask(Task task)
        {
            //Select the specified task
            selectedTask = task;
            UpdateTaskInformation();
        }

        //Synchronizes the task information with the selected task
        void UpdateTaskInformation()
        {
            //Update basic information
            NameTextbox.Text = selectedTask.Name;
            CompleteCheckbox.Checked = selectedTask.IsComplete;
            DescriptionTextbox.Text = selectedTask.Description;

            //TODO: Remove custom task item controls and setup for selected task...
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            //Update the selected tasks name
            ((TaskManagerForm)Parent).taskListControl.SetSelectedTaskName(NameTextbox.Text);

            //Refocus on textbox
            NameTextbox.Focus();
            NameTextbox.SelectionStart = NameTextbox.Text.Length;
        }

        private void DescriptionTextbox_TextChanged(object sender, EventArgs e)
        {
            //Update the selected tasks description
            selectedTask.Description = DescriptionTextbox.Text;
        }

        private void CompleteCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //Update the selected tasks is complete flag
            selectedTask.IsComplete = CompleteCheckbox.Checked;
        }
    }
}
