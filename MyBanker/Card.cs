
using MyBanker.Interfaces;


namespace MyBanker;

internal abstract class Card : IPay, IWithdraw, IDeposit
{
    public string Name { get; private set; }
    public string CardNumber { get; private set; }
    public string AccountNumber { get; private set; }
    public int MinAge { get; private set; }

    /// <summary>
    /// Constructor with params to create card, and calling method CreateCardNumber
    /// </summary>
    /// <param name="name"></param>
    /// <param name="accountNumber"></param>
    /// <param name="minAge"></param>
    /// <param name="prefixes"></param>
    protected Card(string name, string accountNumber, int minAge, string[] prefixes)
    {
        Name = name;
        CardNumber = CreateCardNumber(prefixes);
        AccountNumber = accountNumber;
        MinAge = minAge;


    }
    /// <summary>
    /// Virtual method standard to create the card number
    /// </summary>
    /// <param name="prefixes"></param>
    /// <returns></returns>
    public virtual string CreateCardNumber(string[] prefixes)
    {
        Random r = new Random();
        string prefix = prefixes[r.Next(0, prefixes.Length)];
        string cardNumber = "";
        for (int i = 0; i < 16 - prefix.Length; i++)
        {
            cardNumber += r.Next(0, 10);
        }
        return $"{prefix}{cardNumber}";
    }

    /// <summary>
    /// Virtual method to write in console when you pay
    /// </summary>
    /// <param name="amount"></param>
    public virtual void Pay(int amount)
    {
        Console.WriteLine($"Paying with {this.GetType().Name} amount: {amount} ");
    }
    /// <summary>
    /// Virtual method to write in console for Withdrawing
    /// </summary>
    /// <param name="amount"></param>
    public virtual void Withdraw(int amount)
    {
        Console.WriteLine($"Withdrawing money from {this.GetType().Name} ");
    }
    /// <summary>
    /// Virtual method to write in console for Depositing
    /// </summary>
    /// <param name="amount"></param>
    public virtual void Deposit(int amount)
    {
        Console.WriteLine($"Depositing money to {this.GetType().Name}");
    }
     
}
