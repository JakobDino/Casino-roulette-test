using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino_test.Codes
{
    internal class Roulette
    {
        public int Spin()
        {
            Random random = new Random();
            int nummer = random.Next(37);
            return nummer;
        }

        public Color ColorOutcome(int? input)
        {
            if ((input > 0 && input < 11) || (input > 18 && input < 29))
            {
                if (input % 2 == 0) return Color.Black;
                return Color.Red;
            }
            else if ((input > 10 && input < 19) || (input > 28 && input < 37))
            {
                if (input % 2 == 0) return Color.Red;
                return Color.Black;
            }
            else return Color.Green;
        }

    }
}
