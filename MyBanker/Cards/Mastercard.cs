using MyBanker.Interfaces;

namespace MyBanker.Cards;

internal class Mastercard : Card, ICredit,IMonthlySpending
{
    private static string[] _prefixes = new string[5] { "51","52","53","54","55" };
    public long limit { get; set; } = 30000;
    public long Credit { get; set; } = 40000;
    public Mastercard(string name, string accountNumber):base(name ,accountNumber, 0, _prefixes)
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
