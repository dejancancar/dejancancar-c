using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTests
    {
        [DataTestMethod]
        [DataRow("BeetleJuice", 4 ,"BeeBeeBeeBee")]
        [DataRow("Banana", 1, "Ban")]
        [DataRow("BeetleJuice", 0, "")]
        [DataRow("Be", 2, "BeBe")]
        [DataRow("BeetleJuice",12, "BeeBeeBeeBeeBeeBeeBeeBeeBeeBeeBeeBee")]

        public void Generating_String_And_Returning_Specific_Amount_Of_Times(string inputString, int timesRepeated, string expectedResult)
        {
            //Arrange
            FrontTimes checkString = new FrontTimes();
            // Act
            string actualResult = checkString.GenerateString(inputString, timesRepeated);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
