using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        int _result;

        public int Calculate(string s)
        {
            var result = 0;
            if (s.Contains("+") && s.Contains("-"))
            {
                var operators = s.Split('+');
                foreach (var @operator in operators)
                {
                    if (@operator.Contains('-'))
                    {
                        _result += Substract(@operator);
                    }
                    else
                    {
                        _result += Convert.ToInt32(@operator);
                    }
                }
                return _result;
            }
            
            if (s.Contains("-"))
            {
                return Substract(s);
            }
            var numbers = s.Split('+');
            foreach (var number in numbers)
            {
                _result += Convert.ToInt32(number);
            }
            return _result;
        }

        int Substract(string s)
        {
            var numbersToSubtract = s.Split('-');
            _result = Convert.ToInt32(numbersToSubtract.First());
            for (int i = 1; i < numbersToSubtract.Length; i++)
                _result -= Convert.ToInt32(numbersToSubtract[i]);
            return _result;
        }
    }
}