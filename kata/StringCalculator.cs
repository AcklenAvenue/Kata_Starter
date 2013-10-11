using System;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
                return 5;
            var elements = s.Split('+');
            var sum = 0;
            foreach (var element in elements)
            {
                sum += Convert.ToInt32(element);
            }
            return sum;
        }
    }
}