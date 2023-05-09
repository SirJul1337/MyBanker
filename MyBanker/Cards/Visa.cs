using MyBanker.Interfaces;

namespace MyBanker.Cards;

internal class Visa : Card, ICredit,IMonthlySpending
{
    private static string[] _prefixes = new string[1] { "4" };
    public long limit { get; set; } = 20000;
    public long Credit { get; set; } = 25000;

    public Visa(string name, string accountNumber) : base(name, accountNumber, 18, _prefixes)
    {

    }
    /// <summary>
    /// Method overriding pay method from IPay in Card superclass, to implement limit from IMonthlyPay
    /// </summary>
    /// <param name="amount"></param>
    public override void Pay(int amount)
    {
        //TODO: Implementation of Credit
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
