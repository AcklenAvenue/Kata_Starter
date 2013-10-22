using System.Linq;
using System;
namespace kata
{
    public class Calculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                var nums = s.Split('-').Select(c=>Convert.ToInt32(c)).ToArray();
                return  nums[0]- nums[1];
            }
            return s.Split('+').Select(c => Convert.ToInt32(c)).Sum(c => c);
        }
    }
}