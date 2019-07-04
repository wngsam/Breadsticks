using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breadsticks.Models
{
    public class CreditCard : Account
    {
        private string name;
        private string nickname;
        private DateTime dueDate;

        public CreditCard(string cardName)
        {
            SetName(cardName);
            SetBalance(0.0m);
        }

        public CreditCard(string cardName, decimal initBalance)
        {
            SetName(cardName);
            SetBalance(initBalance);
        }

        public string SetName(string newName)
        {
            name = newName;
            return name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
