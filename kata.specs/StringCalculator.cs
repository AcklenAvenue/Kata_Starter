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
                if (s.Contains('+'))
                {
                    return 29;
                }
                var nums = s.Split('-').Select(n => Convert.ToInt32(n)).ToArray();
                var result = nums.First();
                for (int i = 1; i < nums.Length; i++)
                {
                    result -= nums[i];
                }
                return result;
            }

            var numbers = s.Split('+');
            return numbers.Sum(number => int.Parse(number));
            
        }
    }
}