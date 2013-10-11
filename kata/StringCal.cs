using System;
using System.Linq;

namespace kata
{
    public class StringCal
    {
        public int Calculate(string s)
        {
            var n = s.Split('+');
            var res = 0;
            foreach (var value in n)
            {
                if (value.Contains("-"))
                {
                    res += Subs(value);
                }
                else
                {
                    res += Convert.ToInt32(value);
                }
            }

            return res;
        }

        static int Subs(string s)
        {
            var resta = s.Split('-');
            var total = Convert.ToInt32(resta.First());
            for (int i = 1; i < resta.Length; i++)
            {
                total -= Convert.ToInt32(resta[i]);
            }
            return total;
        }
    }
}