using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {
        [DataTestMethod]
        [DataRow(5, 10, 2)]
        [DataRow(5, 2, 0)]
        [DataRow(5, 5, 1)]
        [DataRow(0, 0, 0)]
        [DataRow(1, 1, 0)]
        [DataRow(2, 2, 0)]
        [DataRow(3, 3, 1)]
        [DataRow(7, 7, 1)]
        [DataRow(8, 8, 2)]
        [DataRow(9, 9, 2)]
        [DataRow(10, 10, 2)]
        [DataRow(0, 1, 0)]
        [DataRow(1, 1, 0)]
        [DataRow(2, 1, 0)]
        [DataRow(3, 1, 0)]
        [DataRow(7, 1, 0)]
        [DataRow(8, 1, 0)]
        [DataRow(9, 1, 0)]
        [DataRow(10, 1, 0)]
        [DataRow(0, 2, 0)]
        [DataRow(1, 2, 0)]
        [DataRow(2, 2, 0)]
        [DataRow(3, 2, 0)]
        [DataRow(7, 2, 0)]
        [DataRow(8, 2, 0)]
        [DataRow(9, 2, 0)]
        [DataRow(10, 2, 0)]
        [DataRow(0, 3, 0)]
        [DataRow(1, 3, 0)]
        [DataRow(2, 3, 0)]
        [DataRow(3, 3, 1)]
        [DataRow(7, 3, 1)]
        [DataRow(8, 3, 2)]
        [DataRow(9, 3, 2)]
        [DataRow(10, 3, 2)]
        [DataRow(0, 7, 0)]
        [DataRow(1, 7, 0)]
        [DataRow(2, 7, 0)]
        [DataRow(3, 7, 1)]
        [DataRow(7, 7, 1)]
        [DataRow(8, 7, 2)]
        [DataRow(9, 7, 2)]
        [DataRow(10, 7, 2)]
        [DataRow(0, 8, 0)]
        [DataRow(1, 8, 0)]
        [DataRow(2, 8, 0)]
        [DataRow(3, 8, 2)]
        [DataRow(7, 8, 2)]
        [DataRow(8, 8, 2)]
        [DataRow(9, 8, 2)]
        [DataRow(10, 8, 2)]
        [DataRow(0, 9, 0)]
        [DataRow(1, 9, 0)]
        [DataRow(2, 9, 0)]
        [DataRow(3, 9, 2)]
        [DataRow(7, 9, 2)]
        [DataRow(8, 9, 2)]
        [DataRow(9, 9, 2)]
        [DataRow(10, 9, 2)]
        public void Do_You_Get_A_Table(int userScore, int dateScore, int expectedScore)
        {
            //Arrange
            DateFashion getATable = new DateFashion();

            // Act
            int actualScore = getATable.GetATable(userScore, dateScore);

            // Assert
            Assert.AreEqual(expectedScore, actualScore);

        }


    }
}
