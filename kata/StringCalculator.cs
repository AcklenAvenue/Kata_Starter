using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var nums = s.Split('+');
            var result = 0;
            foreach (string num in nums)
            {
                if (num.Contains("-"))
                {
                    result += Subtract(num);
                }
                else
                {
                    result += Add(num);
                }
            }
            return result;
        }

        static int Add(string s)
        {
            string[] value = s.Split('+');


            return value.Select(c => Convert.ToInt32(c)).Sum(c => c);
        }

        static int Subtract(string s)
        {
            string[] numbers = s.Split('-');
            int result = Convert.ToInt32(numbers.First());
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= Convert.ToInt32(numbers[i]);
            }
            return result;
        }
    }
}