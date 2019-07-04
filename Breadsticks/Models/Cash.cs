using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breadsticks.Models
{
    public class Cash : Account
    {
        public Cash(string nickname = "", decimal initBalance = 0.0m)
        {
            SetName("Cash");
            SetNickName(nickname);
            SetBalance(initBalance);
            SetTypeAsAsset();
        }

    }
}
