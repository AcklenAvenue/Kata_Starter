using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var numbers = s.Split('+');
            var result = 0;
            foreach (var number in numbers)
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
            var num = s.Split('-').Select(c => Convert.ToInt32(c)).ToArray();
            var result = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                result -= num[i];
            }
            return result;
        }
    }
}