namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }

        public decimal withDrawFee = 2;
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (this.Balance < 150 + withDrawFee && this.Balance >= amountToWithdraw + withDrawFee)
            {
                return base.Withdraw(amountToWithdraw + withDrawFee);
            }
            if(this.Balance > 150 + amountToWithdraw )
            {
                return base.Withdraw(amountToWithdraw);
            }
            else return this.Balance;
        }

    }
}
