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
                if (s.Contains("+"))
                    return 0;
                var nums = s.Split('-');
                var result = Convert.ToInt32(nums.First());
                for (int i = 1; i < nums.Length; i++)
                {
                    result -= Convert.ToInt32(nums[i]);
                }
                return result;
            }
            
           var numbers =  s.Split('+');
           return numbers.Sum(number => int.Parse(number));
        }
    }
}