using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class BankCustomer
    {
        List<IAccountable> accountables = new List<IAccountable>();
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip
        {
            get
            {
                //need balance total from all the accounts
                bankAccountTotal();
                return qualifyForVip;
            }
        }


        public BankCustomer()
        {
            
        }
        //add new account to customers list of accounts
        public void AddAccount(IAccountable newAccount)
        {
            accountables.Add(newAccount);
        }
        public IAccountable[] GetAccounts()
        {

            return accountables.ToArray();
        }

        private bool qualifyForVip;
        private void bankAccountTotal()
        {
            int balanceTotal = 0;
            foreach (IAccountable account in accountables)
            {
                balanceTotal += account.Balance;

            }
            if (balanceTotal >= 25000)
            {
                qualifyForVip = true;
            }
            else
            {
                qualifyForVip = false;
            }

        }
    }
}
