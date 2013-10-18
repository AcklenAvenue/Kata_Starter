using System;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var value = s.Split('+');

            return Convert.ToInt32(value[0]) + Convert.ToInt32(value[1]);
        }
    }
}