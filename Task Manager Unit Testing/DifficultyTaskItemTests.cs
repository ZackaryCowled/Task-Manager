using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_Manager;
using Task_Manager.TaskItems;

namespace Task_Manager_Unit_Testing
{
    [TestClass]
    public class DifficultyTaskItemTests
    {
        [TestMethod]
        [TestCategory("Difficulty Task Item Tests")]
        public void SetDifficultyValueTest()
        {
            //Arrange
            Project project = new Project();
            Task task = project.AddTask();
            DifficultyTaskItem difficultyTaskItem = (DifficultyTaskItem)task.AddTaskItem(typeof(DifficultyTaskItem));
            int expectedDifficultyValue = 100;

            //Act
            difficultyTaskItem.difficultyValue = expectedDifficultyValue;

            //Assert
            Assert.AreEqual(difficultyTaskItem.difficultyValue, expectedDifficultyValue);
        }
    }
}
