using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Tests
    {
        [DataTestMethod]
        [DataRow(0, false)]
        [DataRow(1, false)]
        [DataRow(14, false)]
        [DataRow(18, true)]
        [DataRow(19, true)]
        [DataRow(20, false)]
        [DataRow(21, false)]
        [DataRow(37, false)]
        [DataRow(38, true)]
        [DataRow(39, true)]
        [DataRow(40, false)]
        [DataRow(41, false)]
        [DataRow(397, false)]
        [DataRow(398, true)]
        [DataRow(399, true)]
        [DataRow(400, false)]
        [DataRow(401, false)]
        public void One_Or_Two_Less_Than_Twenty(int inputNumber, bool expectedResult)
        {
            // Arrange
            Less20 testNumber = new Less20();

            // Act
            bool actualResult = testNumber.IsLessThanMultipleOf20(inputNumber);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

    }
}
