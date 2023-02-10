using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino_test.Codes
{
    internal class Balance
    {
        private int? balance =500;

        public void Deposit(int input)
        {
            balance += input;
        }
        public void Withdraw(int input)
        {
            balance -= input;
        }
        public int? GetBalance()
        {
            return balance;
        }


        public bool BalanceCheck(DataModel model) //property??
        {
            if (model.BetAmount <= balance)
            {
                return true;
            }
            return false;
        }
    }
}
