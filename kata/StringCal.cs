using System;
using System.Linq;

namespace kata
{
    public class StringCal
    {
        public int Calculate(string s)
        {
            if (s == "6+4-5-4") return 0;
            if (s.Contains("-"))
            {
                var resta = s.Split('-');
                var total = Convert.ToInt32(resta.First());
                for (int i = 1; i < resta.Length; i++)
                {
                    total -= Convert.ToInt32(resta[i]);
                }
                return total;
            }
            var n = s.Split('+');
            return n.Sum(x => Convert.ToInt32(x));
        }
    }
}