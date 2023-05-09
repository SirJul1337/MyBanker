using MyBanker.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker;

internal abstract class Card
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

}
