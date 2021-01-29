using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {
        [TestMethod]
        
        public void Test_Array_For_One_Or_3()
        {
            int[] array1 = new int[] { 0, 2, 4 };


            //Arrange
            Lucky13 testArrays = new Lucky13();
            bool expectedResult = true;
            

            
            //Act
            bool actualResult = testArrays.GetLucky(array1);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

    }
}
