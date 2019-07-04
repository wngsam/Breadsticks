using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breadsticks.Models
{
    public class Account
    {
        private decimal balance;
        private string name;
        private string nickname;
        private string acctType;

        protected Account(){}

        protected string SetTypeAsAsset()
        {
            acctType = AccountTypes.ASSET_TYPE;
            return acctType;
        }
        protected string SetTypeAsDebt()
        {
            acctType = AccountTypes.DEBT_TYPE;
            return acctType;
        }

        public string GetAcctType()
        {
            return acctType;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public decimal SetBalance(decimal newBalance)
        {
            balance = newBalance;
            return balance;
        }

        public decimal AddToBalance(decimal amount)
        {
            balance += amount;
            return balance;
        }

        public string GetName()
        {
            return name;
        }

        public string SetName(string newName)
        {
            name = newName;
            return name;
        }

        public string GetNickName()
        {
            return nickname;
        }

        public string SetNickName(string newNickname)
        {
            nickname = newNickname;
            return nickname;
        }
    }
}
