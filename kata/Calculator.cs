using System;
using System.Linq;

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
                var numbers = s.Split('-');
                var result = Convert.ToInt32(numbers.First());
                for (int i = 1; i < numbers.Length; i++)
                {
                    result -= Convert.ToInt32(numbers[i]);
                }
                return result;
            }

            return s.Split('+').Select(n => Convert.ToInt32(n)).Sum();
        }
    }
}