using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CreditCardAccount : IAccountable
    {
        public int Balance { get; set; }
        //{
        //    get
        //    {
        //        return -Debt;
        //    }
        //    set;
        //}


        public string AccountHolderName { get; }
        public string AccountNumber { get; }
        public int Debt
        {
            get
            {
                return -this.Balance;
                /*return amountOwed;*/              
            }
        }
        //private int AmountOwed { get; set; }
        //private int amountOwed = 0;
        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;


        }
        public int Pay(int amountToPay)
        {
            this.Balance += amountToPay;
            //amountOwed -= amountToPay;
            return this.Balance;
        }

        public int Charge(int amountToCharge)
        {
            this.Balance -= amountToCharge;
            //amountOwed += amountToCharge;
            return this.Balance;
        }
    }
}
