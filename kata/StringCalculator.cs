using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        int _result;

        public int Calculate(string s)
        {
            if (s.Contains("+") && s.Contains("-")) return 0;
            if (s.Contains("-"))
            {
                var numbersToSubtract = s.Split('-');
                _result = Convert.ToInt32(numbersToSubtract.First());
                for (int i = 1; i < numbersToSubtract.Length; i++)
                    _result -= Convert.ToInt32(numbersToSubtract[i]);
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