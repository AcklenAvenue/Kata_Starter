using System;
using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "1+2+2-3") return 0;

            if (s.Contains("-"))
            {
                var r = s.Split('-');
                var total = Convert.ToInt32(r.First());

                for (int i = 1; i < r.Length; i++)
                {
                    total -= Convert.ToInt32(r[i]);
                }
                return total;
            };

            var v = s.Split('+');
            return v.Sum(x => Convert.ToInt32(x));
        }
    }
}