using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino_test.Mathias
{
    public class Respond<T>
    {
        public bool Succes { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }

    public class TestRespond
    {
        public Respond<Color> OutcomeWithRespond(int input)
        {
            var respond = new Respond<Color>() { Succes = true, Data = Color.Green };

            if (input == 0)
            {
                return new Respond<Color>() { Succes = true, Data = Color.Green };
            }
            else if (input > 0 && input < 11)
            {
                if (input % 2 == 0)
                {
                    return new Respond<Color>() { Succes = true, Data = Color.Black }; //enum???
                }
            }
            return new Respond<Color>() { Succes = false, Message = "Color Not fundt" };
        }
    }
}
