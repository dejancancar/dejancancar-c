using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        [DataTestMethod]
        [DataRow(-1, true, false)]
        [DataRow(0, true, false)]
        [DataRow(10, true, false)]
        [DataRow(20, true, false)]
        [DataRow(30, true, false)]
        [DataRow(39, true, false)]
        [DataRow(40, true, true)]
        [DataRow(41, true, true)]
        [DataRow(42, true, true)]
        [DataRow(45, true, true)]
        [DataRow(48, true, true)]
        [DataRow(49, true, true)]
        [DataRow(50, true, true)]
        [DataRow(51, true, true)]
        [DataRow(55, true, true)]
        [DataRow(60, true, true)]
        [DataRow(70, true, true)]
        [DataRow(80, true, true)]
        [DataRow(90, true, true)]
        [DataRow(100, true, true)]
        [DataRow(1000, true, true)]
        [DataRow(10000, true, true)]
        [DataRow(-6, false, false)]
        [DataRow(0, false, false)]
        [DataRow(10, false, false)]
        [DataRow(20, false, false)]
        [DataRow(30, false, false)]
        [DataRow(39, false, false)]
        [DataRow(40, false, true)]
        [DataRow(41, false, true)]
        [DataRow(42, false, true)]
        [DataRow(45, false, true)]
        [DataRow(48, false, true)]
        [DataRow(49, false, true)]
        [DataRow(50, false, true)]
        [DataRow(51, false, true)]
        [DataRow(55, false, true)]
        [DataRow(60, false, true)]
        [DataRow(70, false, false)]
        [DataRow(80, false, false)]
        [DataRow(90, false, false)]
        [DataRow(100, false, false)]
        [DataRow(1000, false, false)]
        [DataRow(10000, false, false)]
        public void Number_Of_Cigars_And_True_If_Having_Party(int cigarInput, bool isWeekend, bool isAParty)
        {
            //Arrange
            CigarParty partyCheck = new CigarParty();

            //Act
            bool result = partyCheck.HaveParty(cigarInput,isWeekend);

            //Assert
            Assert.AreEqual(isAParty,result);

        }

    }
}
