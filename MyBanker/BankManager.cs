using MyBanker.Cards;
using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    
    internal class BankManager
    {
        public static List<Card> Cards;
        public static List<Account> Accounts;
        public BankManager()
        {
            Cards = new List<Card>();
            Accounts = new List<Account>();
            Account acc = new Account("Niklas", 18);
            Account acc1 = new Account("Peter", 15);
            Accounts.Add(acc);
            Accounts.Add(acc1);
            Card card = new Maestro(acc.Name, acc.AccountNumber);
            acc.AddNewCard(card);
            Card visaE = new VisaElectron(acc1.Name, acc1.AccountNumber);
            acc1.AddNewCard(visaE);
            UseAllCards();
        }
        /// <summary>
        /// Used for testing every card in the system
        /// </summary>
        private void UseAllCards()
        {
            foreach (Card card in Cards)
            {
                
                Console.WriteLine($"Name:{card.Name} \nAccount: {card.AccountNumber}\nCard: ({card.CardNumber})"); 
                if(card is IPay pc) 
                {
                    pc.Pay(10000);
                }

                if(card is IWithdraw wc)
                {
                    wc.Withdraw(20000);
                }

                if(card is IDeposit dc)
                {
                    dc.Deposit(1000000);
                }
                Console.WriteLine("--------------------------------");
            }
            
        }
    }
}
