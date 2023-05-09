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
            Account acc1 = new Account("Peter", 18);
            Accounts.Add(acc);
            Accounts.Add(acc1);


            foreach (Account accounts in Accounts)
            {
                accounts.GetAllCards();
               
                Card card = new Maestro(accounts.Name, accounts.AccountNumber);
                accounts.AddNewCard(card);
            }
            UseAllCards();
        }
        public static List<Card> GetCards()
        {
            return Cards;
        }
        private void UseAllCards()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine($"Card ({card.CardNumber}) on account {card.AccountNumber}"); 
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
