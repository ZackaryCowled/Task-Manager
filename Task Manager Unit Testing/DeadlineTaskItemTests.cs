using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_Manager;
using Task_Manager.TaskItems;

namespace Task_Manager_Unit_Testing
{
    [TestClass]
    public class DeadlineTaskItemTests
    {
        [TestMethod]
        [TestCategory("Deadline Task Item Tests")]
        public void SetMonthIndexTest()
        {
            //Arrange
            Project project = new Project();
            Task task = project.AddTask();
            DeadlineTaskItem deadlineTaskItem = (DeadlineTaskItem)task.AddTaskItem(typeof(DeadlineTaskItem));
            int expectedMonthIndex = 12;

            //Act
            deadlineTaskItem.monthIndex = expectedMonthIndex;

            //Assert
            Assert.AreEqual(deadlineTaskItem.monthIndex, expectedMonthIndex);
        }

        [TestMethod]
        [TestCategory("Deadline Task Item Tests")]
        public void SetDayIndexTest()
        {
            //Arrange
            Project project = new Project();
            Task task = project.AddTask();
            DeadlineTaskItem deadlineTaskItem = (DeadlineTaskItem)task.AddTaskItem(typeof(DeadlineTaskItem));
            int expectedDayIndex = 30;

            //Act
            deadlineTaskItem.dayIndex = expectedDayIndex;

            //Assert
            Assert.AreEqual(deadlineTaskItem.dayIndex, expectedDayIndex);
        }

        [TestMethod]
        [TestCategory("Deadline Task Item Tests")]
        public void SetHourIndex()
        {
            //Arrange
            Project project = new Project();
            Task task = project.AddTask();
            DeadlineTaskItem deadlineTaskItem = (DeadlineTaskItem)task.AddTaskItem(typeof(DeadlineTaskItem));
            int expectedHourIndex = 23;

            //Act
            deadlineTaskItem.hourIndex = expectedHourIndex;

            //Assert
            Assert.AreEqual(deadlineTaskItem.hourIndex, expectedHourIndex);
        }

        [TestMethod]
        [TestCategory("Deadline Task Item Tests")]
        public void SetMinuteIndex()
        {
            //Arrange
            Project project = new Project();
            Task task = project.AddTask();
            DeadlineTaskItem deadlineTaskItem = (DeadlineTaskItem)task.AddTaskItem(typeof(DeadlineTaskItem));
            int expectedMinuteIndex = 59;

            //Act
            deadlineTaskItem.minuteIndex = expectedMinuteIndex;

            //Assert
            Assert.AreEqual(deadlineTaskItem.minuteIndex, expectedMinuteIndex);
        }
    }
}
