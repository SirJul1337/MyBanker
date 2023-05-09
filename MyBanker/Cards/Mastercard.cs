using MyBanker.Interfaces;

namespace MyBanker.Cards;

internal class Mastercard : Card, IPay, IWithdraw, IDeposit, IMonthlySpending
{
    private static string[] _prefixes = new string[5] { "51","52","53","54","55" };
    public Mastercard(string name, string accountNumber):base(name ,accountNumber, 0, _prefixes)
    {
    }

    public long limit { get; set; } = 30000;



    public void Deposit(int amount)
    {
        throw new NotImplementedException();
    }

    public void Pay(int amount)
    {
        throw new NotImplementedException();
    }

    public void Withdraw(int amount)
    {
        Console.WriteLine($"Withdrawing money from {this.GetType().Name} ");
    }
}
