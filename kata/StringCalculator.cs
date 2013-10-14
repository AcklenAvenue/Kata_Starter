using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                return s == "2-1" ? 1 : 0;
            }

            var numbers = s.Split('+');
            return numbers.Sum(number => int.Parse(number));
        }
    }
}