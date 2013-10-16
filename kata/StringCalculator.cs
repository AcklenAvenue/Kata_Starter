using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var number = s.Split('+');
            var result = 0;
            foreach (var num in number)
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
            return s.Split('+').Select(c => Convert.ToInt32(c)).Sum(c => c);
        }

        static int Subtract(string s)
        {
            var numbers = s.Split('-');
            var result = Convert.ToInt32(numbers.First());
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= Convert.ToInt32(numbers[i]);
            }
            return result;
        }
    }
}