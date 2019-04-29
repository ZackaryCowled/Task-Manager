using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class SelectTaskItemDialog : Form
    {
        public Type SelectedTaskItemType { get; set; }

        List<Type> taskItemTypes;

        //Initialize and setup a select task item dialog
        public SelectTaskItemDialog()
        {
            //Initialize components
            InitializeComponent();

            //Setup dialog results
            SelectButton.DialogResult = DialogResult.OK;
            TerminateButton.DialogResult = DialogResult.Cancel;

            //Initialize and setup task item types lists
            InitializeTaskItemTypesList();
            PopulateTaskItemTypesList();
        }

        //Initializes the task item types list
        private void InitializeTaskItemTypesList()
        {
            //Initialize task item types list
            taskItemTypes = new List<Type>();

            //For each derived type of task item
            foreach (Type derivedType in Assembly.GetAssembly(typeof(TaskItem)).GetTypes().Where(type => type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(TaskItem))))
            {
                //Add type to the task item types
                taskItemTypes.Add(derivedType);
            }
        }

        //Populates the task item types list with the names in the type list
        private void PopulateTaskItemTypesList()
        {
            //For each task item type
            foreach(Type type in taskItemTypes)
            {
                //Add task item type to the task item type list
                TaskItemTypeList.Items.Add(type.Name);
            }
        }

        //Called on task item type selected index change
        private void TaskItemTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If the index is valid
            if(TaskItemTypeList.SelectedIndex >= 0)
            {
                //Update the selected task item type
                SelectedTaskItemType = taskItemTypes[TaskItemTypeList.SelectedIndex];
            }
        }
    }
}
