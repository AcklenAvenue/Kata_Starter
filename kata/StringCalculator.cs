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
                var minus = s.Split('-');
                return int.Parse(minus[0]) - int.Parse(minus[1]);
            }

            var numbers = s.Split('+');
            return numbers.Sum(number => int.Parse(number));
        }
    }
}