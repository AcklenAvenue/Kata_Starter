using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                var Nums = s.Split('-');
                var total = Convert.ToInt32(Nums.First());
                return total - Convert.ToInt32(Nums[1]);
            }
            return s.Split('+').Sum(value => Convert.ToInt32(value));
        }
    }
}