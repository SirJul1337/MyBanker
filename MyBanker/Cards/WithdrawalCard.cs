using MyBanker.Interfaces;

namespace MyBanker.Cards;

internal class WithdrawalCard : Card, IDeposit, IWithdraw
{
    private static string[] _prefixes = new string[1] { "2400" };
    
    public WithdrawalCard(string name, string accountNumber):base(name ,accountNumber,0, _prefixes)
    {
    }


    public void Deposit(int amount)
    {

    }
    public void Withdraw(int amount) 
    {
        Console.WriteLine($"Withdrawing money from {this.GetType().Name} ");
    }
}
