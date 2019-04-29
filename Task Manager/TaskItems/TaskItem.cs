using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Task_Manager.TaskItems;

namespace Task_Manager
{
    [XmlType("TaskItem")]
    [XmlInclude(typeof(DeadlineTaskItem))]
    [XmlInclude(typeof(DifficultyTaskItem))]
    public abstract class TaskItem
    {
        //Decorates the specified task item control
        public abstract void Decorate(TaskItemControl taskItemControl);

        //Creates and adds a bold label for the task with the specified text to the parent
        protected void CreateTaskLabel(TaskItemControl parent, string text)
        {
            //Create and configure task label
            Label taskLabel = new Label();
            taskLabel.Location = new Point(3, 3);
            taskLabel.AutoSize = true;
            taskLabel.Font = new Font(FontFamily.GenericSansSerif, 8.125f, FontStyle.Bold);
            taskLabel.Text = text;

            //Add label to parent
            parent.Controls.Add(taskLabel);
        }

        //Creates and adds a label with the specified properties to the parent
        protected void CreateLabel(TaskItemControl parent, string text, Point location)
        {
            //Create and configure label
            Label label = new Label();
            label.Location = location;
            label.AutoSize = true;
            label.Text = text;

            //Add label to parent
            parent.Controls.Add(label);
        }

        //Creates and adds a drop down list with the specified label and drop down items to the parent
        protected void CreateDropDownList(TaskItemControl parent, string labelText, Point location, int selectedIndex, EventHandler callback, params string[] dropDownItems)
        {
            //Create and configure drop down list label
            Label dropDownLabel = new Label();
            dropDownLabel.Location = location;
            dropDownLabel.AutoSize = true;
            dropDownLabel.Text = labelText;

            //Create and configure drop down list
            ComboBox dropDownList = new ComboBox();
            dropDownList.Location = new Point(location.X + dropDownLabel.PreferredWidth + 3, location.Y - 3);
            dropDownList.Size = new Size(100, dropDownList.Size.Height);
            dropDownList.DropDownStyle = ComboBoxStyle.DropDownList;

            //If there is at least one drop down item
            if (dropDownItems.Count() > 0)
            {
                //For each drop down item in the drop down items list
                foreach(string dropDownItem in dropDownItems)
                {
                    //Add drop down item to the drop down list
                    dropDownList.Items.Add(dropDownItem);
                }

                //Select the first drop down item
                dropDownList.SelectedIndex = selectedIndex;

                //Subscribe to selected index change event
                dropDownList.SelectedIndexChanged += callback;
            }

            //Add drop down label and list to the parent
            parent.Controls.Add(dropDownLabel);
            parent.Controls.Add(dropDownList);
        }

        //Creates and adds a horizontal slider with the specified properties to the parent
        protected void CreateHorizontalSlider(TaskItemControl parent, Point location, Size size, int value, EventHandler callback, AnchorStyles anchor)
        {
            //Create and configure horizontal slider
            TrackBar horizontalSlider = new TrackBar();
            horizontalSlider.Location = location;
            horizontalSlider.Size = size;
            horizontalSlider.Anchor = anchor;
            horizontalSlider.Minimum = 0;
            horizontalSlider.Maximum = 100;
            horizontalSlider.Value = value;

            //Subscribe to value changed event
            horizontalSlider.ValueChanged += callback;

            //Add label and horizontal slider to the parent
            parent.Controls.Add(horizontalSlider);
        }
    }
}
