
using MyBanker.Interfaces;


namespace MyBanker;

internal abstract class Card : IPay, IWithdraw, IDeposit
{
    public string Name { get; private set; }
    public string CardNumber { get; private set; }
    public string AccountNumber { get; private set; }
    public int MinAge { get; private set; }

    protected Card(string name, string accountNumber, int minAge, string[] prefixes)
    {
        Name = name;
        CardNumber = CreateCardNumber(prefixes);
        AccountNumber = accountNumber;
        MinAge = minAge;


    }
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

    public virtual void Pay(int amount)
    {
        Console.WriteLine($"Paying with {this.GetType().Name} amount: {amount} ");
    }
    public virtual void Withdraw(int amount)
    {
        Console.WriteLine($"Withdrawing money from {this.GetType().Name} ");
    }
    public virtual void Deposit(int amount)
    {
        Console.WriteLine($"Depositing money to {this.GetType().Name}");
    }
     
}
