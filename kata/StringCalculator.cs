using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-") && s.Contains("+"))
                return 0;
            if (s.Contains("-"))
            {
                var Nums = s.Split('-');
                var total = Convert.ToInt32(Nums.First());
                for (int i = 1; i < Nums.Length; i++)
                {
                    total -= Convert.ToInt32(Nums[i]);
                }
                return total;
            }
            return s.Split('+').Sum(value => Convert.ToInt32(value));
        }
    }
}