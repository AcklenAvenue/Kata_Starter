using System;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var v = s.Split('+');
            return Convert.ToInt32(v[0]) + Convert.ToInt32(v[1]);
        }
    }
}