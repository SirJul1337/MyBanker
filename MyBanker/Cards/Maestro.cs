using MyBanker.Interfaces;

namespace MyBanker.Cards;

internal class Maestro : Card, IPay, IWithdraw, IDeposit
{
    private static string[] _prefixes = new string[9] { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };

    public Maestro(string name, string accountNumber) : base(name, accountNumber, 18, _prefixes)
    {
    }

    public override string CreateCardNumber(string[] prefixes)
    {

        Random r = new Random();
        string prefix = prefixes[r.Next(0, prefixes.Length)];
        string cardNumber = "";
        for (int i = 0; i < 19-prefix.Length; i++)
        {
            cardNumber+=r.Next(0, 10);
        }
        return $"{prefix}{cardNumber}";

    }

    public void Deposit(int amount)
    {
        Console.WriteLine($"Depositing into account with {this.GetType().Name} amount: {amount} ");

    }

    public void Pay(int amount)
    {
        Console.WriteLine($"Paying with {this.GetType().Name} amount: {amount} ");
    }

    public void Withdraw(int amount)
    {
        Console.WriteLine($"Withdrawing money from {this.GetType().Name} amount: {amount}");
    }
}
