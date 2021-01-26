namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        //Creat properties
        public string AccountHolderName { get; private set; }

        public string AccountNumber { get; set; }

        public decimal Balance { get; private set; }

        //Create constructors
        public BankAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
        }

        public BankAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = balance;

        }

        //create Methods
        public decimal Deposit(decimal amountToDeposit)
        {
            this.Balance += amountToDeposit;
            return amountToDeposit;
            
        }

        virtual public decimal Withdraw(decimal amountToWithdraw)
        {
            this.Balance = this.Balance - amountToWithdraw ;
            return this.Balance;
        }

    }
}
