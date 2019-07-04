using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breadsticks.Models
{
    public class User
    {

        string userName;
        private List<Account> accounts;

        public User()
        {
            accounts = new List<Account>();
        }

        public User (List<Account> initAccounts)
        {
            accounts = initAccounts;
        }

        public Account GetAccountByIndex(int index)
        {
            return accounts[index];
        }

        public List<Account> GetAssetAccounts()
        {
            List<Account> assets = new List<Account>();

            foreach (Account a in accounts)
            {
                if (a.GetAcctType() == AccountTypes.ASSET_TYPE)
                {
                    assets.Add(a);
                }
            }
            return assets;
        }

        public List<Account> GetDebtAccounts()
        {
            List<Account> debts = new List<Account>();

            foreach (Account a in accounts)
            {
                if (a.GetAcctType() == AccountTypes.DEBT_TYPE)
                {
                    debts.Add(a);
                }
            }
            return debts;
        }

        public decimal GetTotalAsset()
        {
            decimal sum = 0.0m;

            foreach(Account a in accounts)
            {
                if(a.GetAcctType() == AccountTypes.ASSET_TYPE)
                {
                    sum += a.GetBalance();
                }
            }

            return sum;
        }

        public decimal GetTotalDebt()
        {
            decimal sum = 0.0m;

            foreach (Account a in accounts)
            {
                if (a.GetAcctType() == AccountTypes.DEBT_TYPE)
                {
                    sum += a.GetBalance();
                }
            }

            return sum;
        }

        public decimal GetTotalBalance()
        {
            decimal sum = 0.0m;

            foreach (Account a in accounts)
            {
                sum += a.GetBalance();
            }

            return sum;
        }

        public int GetNumOfAccounts()
        {
            return accounts.Count;
        }
    }
}
