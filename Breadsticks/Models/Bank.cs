using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breadsticks.Models
{
    public class Bank : Account
    {
        private decimal interestRate;

        public Bank(string bankName, decimal initBalance, string nickname = "")
        {
            SetName(bankName);
            SetNickName(nickname);
            SetBalance(initBalance);
            SetTypeAsAsset();
        }

        public decimal GetInterestRate()
        {
            return interestRate;
        }

        public decimal SetInterestRate(decimal newInterestRate)
        {
            interestRate = newInterestRate;
            return interestRate;
        }
    }
}
