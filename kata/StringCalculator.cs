using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                if (s.Contains("+"))
                    return 0;
                var num = s.Split('-').Select(c => Convert.ToInt32(c)).ToArray();
                var result = num[0];
                for (int i = 1; i < num.Length; i++)
                {
                    result -= num[i];
                }
                return result;
            }
            return s.Split('+').Select(c => Convert.ToInt32(c)).Sum(c => c);
        }
    }
}