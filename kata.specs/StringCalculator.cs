using System;
using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                var r = s.Split('-');
                var total = Convert.ToInt32(r.First());

                
                return total - Convert.ToInt32(r[1]);
            };

            var v = s.Split('+');
            return v.Sum(x => Convert.ToInt32(x));
        }
    }
}