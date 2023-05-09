using MyBanker.Interfaces;

namespace MyBanker.Cards;

internal class DebitCard : Card
{
    private static string[] _prefixes = new string[1] { "2400" };
    
    /// <summary>
    /// For creating normal Debitcard using name and accountnumber
    /// </summary>
    /// <param name="name"></param>
    /// <param name="accountNumber"></param>
    public DebitCard(string name, string accountNumber):base(name ,accountNumber,0, _prefixes)
    {
    }
    /// <summary>
    /// Used as a superclass for Meastro and Electron cause they are both Debit
    /// </summary>
    /// <param name="name"></param>
    /// <param name="accountNumber"></param>
    /// <param name="age"></param>
    /// <param name="prefixes"></param>
    public DebitCard(string name, string accountNumber, int age, string[] prefixes):base(name, accountNumber, age, _prefixes)
    {
        
    }

}
