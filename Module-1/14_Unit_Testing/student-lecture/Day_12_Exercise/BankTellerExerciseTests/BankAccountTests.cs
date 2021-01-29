using BankTellerExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Constructor_TwoParameterTest()
        {
            //Arrange
            string name = "Dejan";
            string number = "8675309";

            //Act
            BankAccount account = new BankAccount(name, number);
            //Assert - Make sure holder, acct number and balance are all correct
            Assert.AreEqual(name, account.AccountHolderName);
            Assert.AreEqual(number, account.AccountNumber);
            Assert.AreEqual(0, account.Balance);

        }
        [TestMethod]
        public void Constructor_TwoParameters_NullName_ShouldFailArgumentException()
        {
            //Arrange
            BankAccount account = new BankAccount("", "", 1000);
            BankAccount someOtherAccount = new BankAccount("", "", 10);

            //Act
            int transferredAmount = account.TransferTo(someOtherAccount, 600);
            //Assert
            Assert.AreEqual(400, account.Balance);
            Assert.AreEqual(610, someOtherAccount.Balance);
            Assert.AreEqual(600, transferredAmount, $"The TransferTo method should return the amount actually transferred (600). It actually returned {transferredAmount}");
        }

    }
}