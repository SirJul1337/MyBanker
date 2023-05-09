using MyBanker.Interfaces;
namespace MyBanker.Cards;

internal class VisaElectron : Card, IDeposit, IWithdraw, IMonthlySpending
{
    private static string[] _prefixes = new string[6] { "4026", "417500", "4508", "4844", "4913", "4917" };

    public VisaElectron(string name, string accountNumber) : base(name, accountNumber, 15, _prefixes)
    {
    }

    public long limit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



    public void Deposit(int amount)
    {
        throw new NotImplementedException();
    }

    public void Withdraw(int amount)
    {
        Console.WriteLine($"Withdrawing money from {this.GetType().Name} ");
    }
}

