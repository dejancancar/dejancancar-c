using BankTellerExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests
{
    [TestClass]
    public class BankCustomersTests
    {
        [TestMethod]
        public void GetCustomerAccounts()
        {  //Arrange - Create a customer plus some accounts for that customer
            BankCustomer cust = new BankCustomer();
            SavingsAccount savings = new SavingsAccount("asdf", "123");
            CheckingAccount checking1 = new CheckingAccount("asdfj", "123");
            CheckingAccount checking2 = new CheckingAccount("asdfj", "123");

            cust.AddAccount(checking1);
            cust.AddAccount(checking2);
            cust.AddAccount(savings);


            //Act - call getaccounts
            IAccountable[] actualAccounts = cust.GetAccounts();
            //assert - verify all accounts are returned
            IAccountable[] expectedAccounts = new IAccountable[] { savings, checking1, checking2 };
            //CollectionAssert.AreEqual(expectedAccounts, actualAccounts); // has to have the same lineup in the collection that you are checking into
            CollectionAssert.AreEquivalent(expectedAccounts, actualAccounts); // checks to make sure the name is in the collection, order doesn't matter.
        }
    }
}
