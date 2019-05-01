using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_Manager;

namespace Task_Manager_Unit_Testing
{
    [TestClass]
    public class ProjectTests
    {
        [TestMethod]
        [TestCategory("Project Tests")]
        public void AddTaskTest()
        {
            //Arrange
            Project project = new Project();

            //Act
            Task task = project.AddTask();

            //Assert
            Assert.AreNotEqual(task, null);
            Assert.AreEqual(task, project.Tasks[0]);
        }

        [TestMethod]
        [TestCategory("Project Tests")]
        public void RemoveTaskByIndexText()
        {
            //Arrange
            Project project = new Project();
            project.AddTask();

            //Act
            project.RemoveTask(0);

            //Assert
            Assert.AreEqual(project.Tasks.Count, 0);
        }

        [TestMethod]
        [TestCategory("Project Tests")]
        public void RemoveTaskByTaskTest()
        {
            //Arrange
            Project project = new Project();
            Task task = project.AddTask();

            //Act
            project.RemoveTask(task);

            //Assert
            Assert.AreEqual(project.Tasks.Count, 0);
        }

        [TestMethod]
        [TestCategory("Project Tests")]
        public void SaveTest()
        {
            //Arrange
            Project project = new Project();

            //Act
            bool result = project.Save("./saveTestProject.xml");

            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        [TestCategory("Project Tests")]
        public void LoadTest()
        {
            //Arrange
            Project project = new Project();
            project.Save("./loadTestProject.xml");

            //Act
            bool result = project.Load("./loadTestProject.xml");

            //Assert
            Assert.AreEqual(result, true);
        }
    }
}
