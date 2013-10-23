using System;
using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var result = 0;
            if (s.Contains("+"))
            {
                var numbers = s.Split('+');
                foreach (var number in numbers)
                {
                    if (number.Contains('-'))
                    {
                        var nums = number.Split('-');
                        result += Convert.ToInt32(nums.First());
                        for (int i = 1; i < nums.Length; i++)
                        {
                            result -= Convert.ToInt32(nums[i]);
                        }
                    }
                    else
                    {
                        result += Convert.ToInt32(number);
                    }
                }
            }
            else
            {
                var nums = s.Split('-');
                result += Convert.ToInt32(nums.First());
                for (int i = 1; i < nums.Length; i++)
                {
                    result -= Convert.ToInt32(nums[i]);
                }
            }
            return result;
        }
    }
}