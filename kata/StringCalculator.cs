using System;

namespace kata
{
    public class StringCalculator
    {
        int _result;

        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                return 0;
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