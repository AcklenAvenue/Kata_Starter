using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        int _result;

        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                var numbersToSubtract = s.Split('-');
                _result = Convert.ToInt32(numbersToSubtract.First()) - Convert.ToInt32(numbersToSubtract[1]);
                return _result;
            }
            var numbers = s.Split('+');
            foreach (var number in numbers)
            {
                _result += Convert.ToInt32(number);
            }
            return _result;
        }
    }
}