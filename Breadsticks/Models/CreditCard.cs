using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breadsticks.Models
{
    public class CreditCard : Account
    {
        private DateTime dueDate;

        public CreditCard(string cardName, string nickname = "")
        {
            SetName(cardName);
            SetNickName(nickname);
            SetBalance(0.0m);
            SetTypeAsDebt();
        }

        public CreditCard(string cardName, decimal initBalance, string nickname = "")
        {
            SetName(cardName);
            SetNickName(nickname);
            SetBalance(initBalance);
            SetTypeAsDebt();
        }

        public DateTime GetDueDate()
        {
            return dueDate;
        }

        public DateTime SetDueDate(DateTime newDueDate)
        {
            dueDate = newDueDate;
            return dueDate;
        }

    }
}
