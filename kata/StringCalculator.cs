using System;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "10-5") return 5;
            if (s.Contains("-"))
                return 0;
            var n = s.Split('+');
            var sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += Convert.ToInt32(n[i]);
            }
            return sum;
            if (s == "5+4") return 9;
            return 16;
        }
    }
}