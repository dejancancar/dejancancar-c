using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        [TestMethod]
        public void True_If_First_And_Last_Are_The_Same()
        {
            //Arrange
            SameFirstLast testMethod = new SameFirstLast();
            int[] testArray = new int[] {99,1, 3, 5, 511, 99 };
            bool expectedResult = true;
            //Act
            bool actualResult = testMethod.IsItTheSame(testArray);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        public void False_If_First_And_Last_Are_Different()
        {
            //Arrange
            SameFirstLast testMethod = new SameFirstLast();
            int[] testArray = new int[] { 1, 1, 3, 5, 511, 99 };
            bool expectedResult = false;
            //Act
            bool actualResult = testMethod.IsItTheSame(testArray);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }



    }
}
