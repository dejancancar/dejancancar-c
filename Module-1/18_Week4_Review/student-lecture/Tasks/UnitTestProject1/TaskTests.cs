using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tasks.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class TaskTests
    {
        [TestMethod]
        public void TestConstructor1()
        {
            //arrange - nothing to do here

            //act - create a task using the 2-parameter constructor
            DateTime dueDate = DateTime.Now;
            Task task = new Task("test name", dueDate);

            //assert
            Assert.AreEqual(0, task.TaskId);
            Assert.AreEqual(false, task.IsCompleted);
            Assert.AreEqual("test name", task.TaskName);
            Assert.AreEqual(dueDate, task.DueDate);
        }
    }
}
// checklist for why I cannot reference my "class under test"
//is my test project referencing (dependencies - > Projects) the "target" project
//      - If not, add project reference
// Is the "target" class public?
// is the "target" method public?