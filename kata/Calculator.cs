using System;
using System.Linq;

namespace kata
{
    public class Calculator
    {
        public int Calculate(string s)
        {
            string[] numbers = s.Split('+');
            int result = 0;

            foreach (string number in numbers)
            {
                if (number.Contains("-"))
                {
                    result += Subtract(number);
                }
                else
                {
                    result += Add(number);
                }
            }

            return result;
        }

        static int Add(string s)
        {
            return s.Split('+').Select(c => Convert.ToInt32(c)).Sum(c => c);
        }

        static int Subtract(string s)
        {
            int[] nums = s.Split('-').Select(c => Convert.ToInt32(c)).ToArray();
            int result = nums.First();
            for (int i = 1; i < nums.Length; i++)
            {
                result -= nums[i];
            }
            return result;
        }
    }
}