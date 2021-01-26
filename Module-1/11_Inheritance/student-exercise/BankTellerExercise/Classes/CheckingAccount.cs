namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        { }

        public decimal withDrawFee = 10;
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (this.Balance > -100 && this.Balance < 0)
            {

                return base.Withdraw(amountToWithdraw + withDrawFee);
                

            }
            else if(this.Balance > 0)
            {
                return base.Withdraw(amountToWithdraw);
            }
            else
                return base.Balance;
        }

    }


    //If balance is below 0 and is > -100, add $10 overdraft fee



}
