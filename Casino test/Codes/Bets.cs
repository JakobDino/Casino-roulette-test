using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino_test.Codes
{
    internal class Bets
    {
        //Console.WriteLine("Type 1 for even numbers\nType 2 for odd numbers\nType 3 for red numbers\nType 4 for black numbers\nType 5 for 1st 12\nType 6 for 2nd 12\nType 7 for 3rd 12");


        public int BetRoulette(int input, DataModel model)
        {
            if (input == 1)
            {
                
                ;
            }
            return 3;
        }

        public bool BalanceCheck(int? input, DataModel model)
        {
            if (input <= model.Balance)
            {
                model.Balance = model.Balance - input;
                return true;
            }
            return false;
        }
    }
}
