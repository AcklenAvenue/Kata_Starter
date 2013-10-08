using System;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var values = s.Split('+');
            return Convert.ToInt32(values[0]) + Convert.ToInt32(values[1]);
        }
    }
}