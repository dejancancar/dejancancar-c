using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CreditCardAccount : IAccountable
    {
        public int Balance
        {
            get
            {
                return -Debt;
            }
        }

        public string AccountHolderName { get; }
        public string AccountNumber { get; }
        public int Debt
        {
            get
            {
                return amountOwed;
            }
        }
        //private int AmountOwed { get; set; }
        private int amountOwed = 0;
        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;


        }
        public int Pay(int amountToPay)
        {
            
            amountOwed -= amountToPay;
            return this.Debt;
        }

        public int Charge(int amountToCharge)
        {

            amountOwed += amountToCharge;
            return this.Debt;
        }
    }
}
