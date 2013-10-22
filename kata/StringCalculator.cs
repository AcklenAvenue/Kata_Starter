using System;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var n = s.Split('+');
            return Convert.ToInt32(n[0]) + Convert.ToInt32(n[1]);
        }
    }
}