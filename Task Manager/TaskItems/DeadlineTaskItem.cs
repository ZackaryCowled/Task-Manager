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
    [XmlType("DeadlineTaskItem")]
    public class DeadlineTaskItem : TaskItem
    {
        [XmlElement("MonthIndex")]
        public int monthIndex = 0;

        [XmlElement("DayIndex")]
        public int dayIndex = 0;

        [XmlElement("HourIndex")]
        public int hourIndex = 0;

        [XmlElement("MinuteIndex")]
        public int minuteIndex = 0;

        public override void Decorate(TaskItemControl taskItemControl)
        {
            //Add task label
            CreateTaskLabel(taskItemControl, "Deadline");

            //Add date and time labels
            CreateLabel(taskItemControl, "Date", new Point(3, 25));
            CreateLabel(taskItemControl, "Time", new Point(150, 25));

            //Add month and day drop down lists
            CreateDropDownList(taskItemControl, "Month", new Point(3, 45), monthIndex, OnMonthChanged, "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December");
            CreateDropDownList(taskItemControl, "Day", new Point(3, 70), dayIndex, OnDayChanged, "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31");

            //Add hour and minute drop down lists
            CreateDropDownList(taskItemControl, "Hour", new Point(150, 45), hourIndex, OnHourChanged, "12AM", "1AM", "2AM", "3AM", "4AM", "5AM", "6AM", "7AM", "8AM", "9AM", "10AM", "11AM", "12PM", "1PM", "2PM", "3PM", "4PM", "5PM", "6PM", "7PM", "8PM", "9PM", "10PM", "11PM");
            CreateDropDownList(taskItemControl, "Minute", new Point(150, 70), minuteIndex, OnMinuteChanged, "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59");
        }

        //Called on month change
        private void OnMonthChanged(object sender, EventArgs e)
        {
            //Update month
            monthIndex = ((ComboBox)sender).SelectedIndex;
        }

        //Called on day change
        private void OnDayChanged(object sender, EventArgs e)
        {
            //Update month
            dayIndex = ((ComboBox)sender).SelectedIndex;
        }

        //Called on hour change
        private void OnHourChanged(object sender, EventArgs e)
        {
            //Update month
            hourIndex = ((ComboBox)sender).SelectedIndex;
        }

        //Called on minute change
        private void OnMinuteChanged(object sender, EventArgs e)
        {
            //Update month
            minuteIndex = ((ComboBox)sender).SelectedIndex;
        }
    }
}
