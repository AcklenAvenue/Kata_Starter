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
                if (s.Contains("+"))
                    return 0;
                var nums = s.Split('-').Select(c=>Convert.ToInt32(c)).ToArray();
                var result = nums.First();
                for (int i = 1; i < nums.Length; i++)
                {
                    result -= nums[i];
                }
                return  result;
            }
            return s.Split('+').Select(c => Convert.ToInt32(c)).Sum(c => c);
        }
    }
}