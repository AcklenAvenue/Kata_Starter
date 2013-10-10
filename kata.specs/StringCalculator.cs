using System;
using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var v = s.Split('+');
            var result = 0;
            foreach (var value in v)
            {
                if (value.Contains("-"))
                {
                    result += Subtract(value);
                }
                else
                {
                    result += Convert.ToInt32(value);
                }
            }

            return result;
        }

        static int Subtract(string s)
        {
            var r = s.Split('-');
            var total = Convert.ToInt32(r.First());

            for (int i = 1; i < r.Length; i++)
            {
                total -= Convert.ToInt32(r[i]);
            }
            return total;
        }
    }
}