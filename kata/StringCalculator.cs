using System;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var numbers = s.Split('+');
            return Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]);
        }
    }
}