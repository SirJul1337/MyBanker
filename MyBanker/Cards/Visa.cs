using MyBanker.Interfaces;

namespace MyBanker.Cards;

internal class Visa : Card, IPay, IWithdraw, IDeposit, IMonthlySpending
{
    private static string[] _prefixes = new string[1] { "4" };
    public static int MinAge = 18;
    public long limit { get; set; } = 20000;

    public Visa(string name, string accountNumber) : base(name, accountNumber, 18, _prefixes)
    {

    }

    public void Deposit(int amount)
    {
        throw new NotImplementedException();
    }

    public void Pay(int amount)
    {
        if(limit > amount)
        {
            Console.WriteLine($"Withdrawing money from {this.GetType().Name} amount: {amount} ");
        }
        else
        {
            Console.WriteLine($"Amount ({amount}) is bigger than max value ({limit}) could not withdraw");
        }
    }

    public void Withdraw(int amount)
    {
        Console.WriteLine($"Withdrawing money from {this.GetType().Name} ");
    }

}
