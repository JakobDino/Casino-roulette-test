using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino_test.Codes
{
    internal class Bets
    {


        public int BetRoulette(DataModel model)
        {
            //Console.WriteLine("Type 0 for a straight up (specific numbers)\nType 1 for even numbers\nType 2 for odd numbers" +
            // "\nType 3 for red numbers\nType 4 for black numbers\nType 5 for 1st 12\nType 6 for 2nd 12\nType 7 for 3rd 12\nType 8 for 1 to 18\nType 9 for 19 to 36");

            //if (model.Bet == 1 || model.Bet == 2 || model.Bet == 1 || model.Bet == 1 ||)
            //{

            //}
            if (model.Bet==0)
            {
                if (model.Bet==model.Outcome)
                {
                    Console.WriteLine("you won");
                }
                else
                {
                    Console.WriteLine("you lost");
                }
            }
            else if (model.Bet == 1||model.Bet==2)
            {
                if (model.Outcome%2==0)
                {
                    if (model.Bet==1)
                    {
                        Console.WriteLine("you won");
                    }
                    else
                    {
                        Console.WriteLine("you lost");
                    }
                }
                else
                {
                    if (model.Bet == 2)
                    {
                        Console.WriteLine("you won");
                    }
                    else
                    {
                        Console.WriteLine("you lost");
                    }
                }
            }
            else if (model.Bet == 3 || model.Bet == 4)
            {
                if (model.ColorOutcome == Color.Red)
                {
                    if (model.Bet == 3)
                    {
                        Console.WriteLine("you won");
                    }
                    else
                    {
                        Console.WriteLine("you lost");
                    }
                }
                else
                {
                    if (model.Bet == 4)
                    {
                        Console.WriteLine("you won");
                    }
                    else
                    {
                        Console.WriteLine("you lost");
                    }
                }
            }
            //else if (model.Bet == 5)
            //{

            //}
            //else if (model.Bet == 6)
            //{

            //}
            //else if (model.Bet == 7)
            //{

            //}
            //else if (model.Bet == 8)
            //{

            //}
            //else
            //{

            //}

            return 3;
        }
    }
}
