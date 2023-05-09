using MyBanker.Interfaces;
namespace MyBanker.Cards;

internal class VisaElectron : DebitCard
{
    private static string[] _prefixes = new string[6] { "4026", "417500", "4508", "4844", "4913", "4917" };
    public long limit { get; set; } = 10000;

    public VisaElectron(string name, string accountNumber) : base(name, accountNumber, 15, _prefixes)
    {
    }
    /// <summary>
    /// Method overriding pay method from IPay in Card superclass, to implement limit from IMonthlyPay
    /// </summary>
    /// <param name="amount"></param>
    public override void Pay(int amount)
    {
        if (limit > amount)
        {
            Console.WriteLine($"Withdrawing money from {this.GetType().Name} amount: {amount} ");
        }
        else
        {
            Console.WriteLine($"Amount ({amount}) is bigger than max value ({limit}) could not withdraw");
        }
    }

}

