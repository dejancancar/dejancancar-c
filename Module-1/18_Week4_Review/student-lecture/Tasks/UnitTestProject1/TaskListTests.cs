using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Models;

namespace Tasks.Tests
{
    [TestClass]
    public class TaskListTests
    {
        [TestMethod]
        public void AddTask_Test()
        {
            //Arrange - create a new Task object and a new task list
            TaskList tasks = new TaskList("");
            Task task = new Task("test", DateTime.Now);


            //Act - Call AddTask
            task = tasks.AddTask(task);
            //Assert - got a non-zero id, list has a c count of 1, task is not null
            Assert.IsNotNull(task);
            Assert.AreEqual(1, tasks.Count);
            Assert.AreNotEqual(0, task.TaskId);
            Assert.IsTrue(task.TaskId > 0, "AddTask should return a positive integer for new Id"); // important to add a name for what you are testing
        }
    }
}
// why doesn't my test show up in test explorer
//      is your test class public?
//      Do you have a [TestClass] attribute?
//      is there a test method?
//      Do you have [TestMethod] attribute?
//      is the test method public?
//      is the return type of the test-method void?
