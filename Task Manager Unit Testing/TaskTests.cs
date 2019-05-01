using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_Manager;
using Task_Manager.TaskItems;

namespace Task_Manager_Unit_Testing
{
    [TestClass]
    public class TaskTests
    {
        [TestMethod]
        [TestCategory("Task Tests")]
        public void AddDeadlineTaskItemTest()
        {
            //Arrange
            Project project = new Project();
            Task task = project.AddTask();

            //Act
            TaskItem taskItem = task.AddTaskItem(typeof(DeadlineTaskItem));

            //Assert
            Assert.AreNotEqual(taskItem, null);
        }

        [TestMethod]
        [TestCategory("Task Tests")]
        public void AddDifficultyTaskItemTest()
        {
            //Arrange
            Project project = new Project();
            Task task = project.AddTask();

            //Act
            TaskItem taskItem = task.AddTaskItem(typeof(DifficultyTaskItem));

            //Assert
            Assert.AreNotEqual(taskItem, null);
        }

        [TestMethod]
        [TestCategory("Task Tests")]
        public void RemoveTaskItemByIndexTest()
        {
            //Arrange
            Project project = new Project();
            Task task = project.AddTask();
            task.AddTaskItem(typeof(DeadlineTaskItem));

            //Act
            task.RemoveTaskItem(0);

            //Assert
            Assert.AreEqual(task.Items.Count, 0);
        }

        [TestMethod]
        [TestCategory("Task Tests")]
        public void RemoveTaskItemByTaskItemTest()
        {
            //Arrange
            Project project = new Project();
            Task task = project.AddTask();
            TaskItem taskItem = task.AddTaskItem(typeof(DeadlineTaskItem));

            //Act
            task.RemoveTaskItem(taskItem);

            //Assert
            Assert.AreEqual(task.Items.Count, 0);
        }

        [TestMethod]
        [TestCategory("Task Tests")]
        public void SetTaskNameTest()
        {
            //Arrange
            Project project = new Project();
            Task task = project.AddTask();
            string expectedName = "My Task";

            //Act
            task.Name = expectedName;

            //Assert
            Assert.AreEqual(task.Name, expectedName);
        }

        [TestMethod]
        [TestCategory("Task Tests")]
        public void SetTaskIsCompleteTest()
        {
            //Arrange
            Project project = new Project();
            Task task = project.AddTask();
            bool expectedIsComplete = true;

            //Act
            task.IsComplete = expectedIsComplete;

            //Assert
            Assert.AreEqual(task.IsComplete, expectedIsComplete);
        }

        [TestMethod]
        [TestCategory("Task Tests")]
        public void SetTaskDescriptionTest()
        {
            //Arrange
            Project project = new Project();
            Task task = project.AddTask();
            string expectedDescription = "My task description";

            //Act
            task.Description = expectedDescription;

            //Assert
            Assert.AreEqual(task.Description, expectedDescription);
        }
    }
}
