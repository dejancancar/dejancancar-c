using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {
        [DataTestMethod]
        [DataRow("Hello", "Hlo")]
        [DataRow("H", "H")]
        [DataRow(" ", " ")]
        

        public void Return_String_Made_Of_Every_Other_Letter(string input, string expectedResult)
        {
            //Arrange
            StringBits testMethod = new StringBits();
            //Act
            string actualResult = testMethod.GetBits(input);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

    }
}
