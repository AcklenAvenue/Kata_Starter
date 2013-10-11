using System;
using System.Linq;

namespace kata
{
    public class StringCal
    {
        public int Calculate(string s)
        {

            if (s.Contains("-"))
            {
                var resta = s.Split('-');
                var total = Convert.ToInt32(resta.First());

                return total - Convert.ToInt32(resta[1]);
            }
            var n = s.Split('+');
            return n.Sum(x => Convert.ToInt32(x));
        }
    }
}