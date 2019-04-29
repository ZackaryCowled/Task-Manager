using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Task_Manager.TaskItems
{
    [XmlType("DifficultyTaskItem")]
    public class DifficultyTaskItem : TaskItem
    {
        [XmlElement("DifficultyValue")]
        public int difficultyValue = 50;

        public override void Decorate(TaskItemControl taskItemControl)
        {
            //Add task label
            CreateTaskLabel(taskItemControl, "Difficulty");

            //Add horizontal slider
            CreateHorizontalSlider(taskItemControl, new Point(-3, 40), new Size(320, 50), difficultyValue, OnDifficultyValueChanged, AnchorStyles.Left | AnchorStyles.Right);
        }

        //Called on difficulty value change
        private void OnDifficultyValueChanged(object sender, EventArgs e)
        {
            //Update difficulty value
            difficultyValue = ((TrackBar)sender).Value;
        }
    }
}
