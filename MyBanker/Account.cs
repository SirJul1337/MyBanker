using MyBanker.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyBanker
{
    internal class Account
    {
        public string AccountNumber { get; private set; }
        private string prefix = "3520";
        public string Name { get; private set; }
        private int _age;
        public Account(string name, int age)
        {
            this.Name = name;
            this._age = age;
            bool created = false;
            while (!created)
            {
                string tempNumber = CreateAccountNumber();
                if (!BankManager.Accounts.Any(c => c.AccountNumber == tempNumber))
                {
                    AccountNumber = tempNumber;
                    created = true;
                }
            }
        }
        private string CreateAccountNumber()
        {
            Random r = new Random();
            string tempNumber = $"{prefix}{r.NextInt64(1000000000, 9999999999)}";
            return tempNumber;
        }
        public List<Card> GetAllCards()
        {
            return BankManager.Cards.Where(c => c.AccountNumber == AccountNumber).ToList();
        }
        public void AddNewCard(Card card)
        {
            if(card.MinAge <= _age)
            {
                BankManager.Cards.Add(card);
            }
        }
                                                                                                                                                  
    }
    
}
