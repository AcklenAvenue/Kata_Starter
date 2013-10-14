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
            if (s.Contains("+") && s.Contains("-"))
            {
                return 0;
            }
            if (s.Contains("-"))
            {
                var numbersToSubtract = s.Split('-');
                var substractResult = int.Parse(numbersToSubtract[0]);
                for (var i = 1; i < numbersToSubtract.Length; i++)
                {
                    substractResult -= int.Parse(numbersToSubtract[i]);
                }
                return substractResult;
            }

            var numbers = s.Split('+');
            return numbers.Sum(number => int.Parse(number));
        }
    }
}