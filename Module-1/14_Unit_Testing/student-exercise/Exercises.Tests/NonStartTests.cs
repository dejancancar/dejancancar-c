using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        [DataTestMethod]
        [DataRow("dsgsdga","a", "sgsdga")]
        [DataRow("d", "a","")]
        [DataRow("power", "rangers", "owerangers")]

        public void Combine_Two_Strings(string input1, string input2, string expectedString)
        {
            //Arrange
            NonStart testMethod = new NonStart();
            //act
            string resultString = testMethod.GetPartialString(input1, input2);

            //Assert
            Assert.AreEqual(expectedString, resultString);
        }

    }
}
