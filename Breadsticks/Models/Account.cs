using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breadsticks.Models
{
    public class Account
    {
        private decimal balance; 

        protected Account(){}

        protected decimal SetBalance(decimal newBalance)
        {
            balance = newBalance;
            return balance;
        }

        protected decimal GetBalance()
        {
            return balance;
        }

        protected decimal AddToBalance(decimal amount)
        {
            balance += amount;
            return balance;
        }
    }
}
