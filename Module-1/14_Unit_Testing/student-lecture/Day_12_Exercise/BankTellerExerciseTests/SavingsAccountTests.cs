using BankTellerExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests
{
    [TestClass]
    public class SavingsAccountTests
    {

        [DataTestMethod]
        [DataRow(500, 100, 400, DisplayName = "Happy Path Withdrawl")]// display describes test description
        [DataRow(500, 350, 150)]
        [DataRow(500, 351, 147)]
        [DataRow(500, 500, 500)]
        [DataRow(500, 498, 0)]
        [DataRow(500, 499, 500)]
        [DataRow(500, 501, 500)]
        public void Withdraw(int startingBalance, int withdrawalAmount, int expectedNewBalance)
        {
            //Arrange
            //Create a savings account with initial balance
            SavingsAccount account = new SavingsAccount("", "", startingBalance);

            //Act
            //Invoke the withdraw method
            int returnValue = account.Withdraw(withdrawalAmount);


            //Assert
            //Verify the return value 
            //verify the new balance is correct
            Assert.AreEqual(expectedNewBalance, returnValue);

            // Verify the new balance is correct
            Assert.AreEqual(expectedNewBalance, account.Balance);

        }
        //public void Withdraw_BalanceReaches150()
        //{
        //    //Arrange
        //    //Create a savings account with initial balance
        //    SavingsAccount account = new SavingsAccount("", "", 500);

        //    //Act
        //    //Invoke the withdraw method
        //    int returnValue = account.Withdraw(350);


        //    //Assert
        //    //Verify the return value 
        //    //verify the new balance is correct
        //    Assert.AreEqual(150, returnValue);

        //    // Verify the new balance is correct
        //    Assert.AreEqual(150, account.Balance);
        //}
        //public void Withdraw_BalanceBelow150()
        //{
        //    //Arrange
        //    //Create a savings account with initial balance
        //    SavingsAccount account = new SavingsAccount("", "", 500);

        //    //Act
        //    //Invoke the withdraw method
        //    int returnValue = account.Withdraw(351);


        //    //Assert
        //    //Verify the return value 
        //    //verify the new balance is correct
        //    Assert.AreEqual(147, returnValue);

        //    // Verify the new balance is correct
        //    Assert.AreEqual(147, account.Balance);

        //}


    }
}
