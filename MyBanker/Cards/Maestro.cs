using MyBanker.Interfaces;

namespace MyBanker.Cards;

internal class Maestro : DebitCard
{
    private static string[] _prefixes = new string[9] { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };

    public Maestro(string name, string accountNumber) : base(name, accountNumber, 18, _prefixes)
    {
    }

    /// <summary>
    /// Method overriding the virtual method cause card length has to 19
    /// </summary>
    /// <param name="prefixes"></param>
    /// <returns></returns>
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

}
