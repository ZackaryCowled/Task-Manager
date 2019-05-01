using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_Manager;

namespace Task_Manager_Unit_Testing
{
    [TestClass]
    public class SpecialEventHandlerTests
    {
        [TestMethod]
        [TestCategory("Special Event Handler Tests")]
        public void GetTaskManagerFormTest()
        {
            //Arrange
            DateTime nonEventDate = new DateTime(DateTime.Now.Year, 1, 2);
            SpecialEventHandler specialEventHandler = new SpecialEventHandler();

            //Act
            Type taskManagerFormType = specialEventHandler.GetEventValue(nonEventDate);

            //Assert
            Assert.IsTrue(!taskManagerFormType.IsAbstract);
            Assert.AreEqual(taskManagerFormType, typeof(TaskManagerForm));
        }

        [TestMethod]
        [TestCategory("Special Event Handler Tests")]
        public void GetValentinesTaskManagerFormTest()
        {
            //Arrange
            DateTime valentinesDate = new DateTime(DateTime.Now.Year, 2, 14);
            SpecialEventHandler specialEventHandler = new SpecialEventHandler(); 

            //Act
            Type taskManagerFormType = specialEventHandler.GetEventValue(valentinesDate);

            //Assert
            Assert.IsTrue(!taskManagerFormType.IsAbstract);
            Assert.AreEqual(taskManagerFormType.BaseType, typeof(ThemedTaskManagerForm));
            Assert.AreEqual(taskManagerFormType, typeof(ValentinesTaskManagerForm));
        }

        [TestMethod]
        [TestCategory("Special Event Handler Tests")]
        public void GetHalloweenTaskManagerFormTest()
        {
            //Arrange
            DateTime halloweenDate = new DateTime(DateTime.Now.Year, 10, 31);
            SpecialEventHandler specialEventHandler = new SpecialEventHandler();

            //Act
            Type taskManagerFormType = specialEventHandler.GetEventValue(halloweenDate);

            //Assert
            Assert.IsTrue(!taskManagerFormType.IsAbstract);
            Assert.AreEqual(taskManagerFormType.BaseType, typeof(ThemedTaskManagerForm));
            Assert.AreEqual(taskManagerFormType, typeof(HalloweenTaskManagerForm));
        }

        [TestMethod]
        [TestCategory("Special Event Handler Tests")]
        public void GetChristmasTaskManagerFormTest()
        {
            //Arrange
            DateTime christmasDate = new DateTime(DateTime.Now.Year, 12, 25);
            SpecialEventHandler specialEventHandler = new SpecialEventHandler();

            //Act
            Type taskManagerFormType = specialEventHandler.GetEventValue(christmasDate);

            //Assert
            Assert.IsTrue(!taskManagerFormType.IsAbstract);
            Assert.AreEqual(taskManagerFormType.BaseType, typeof(ThemedTaskManagerForm));
            Assert.AreEqual(taskManagerFormType, typeof(ChristmasTaskManagerForm));
        }
    }
}
