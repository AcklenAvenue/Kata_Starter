using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var n = s.Split('+');
            var result = 0;
            foreach (var number in n)
            {
                if (s.Contains("-"))
                {
                    result += Subtract(number);
                }
                else
                {
                    result += Convert.ToInt32(number);
                }
            }
            return result;
        }

        static int Subtract(string s)
        {
            var subtractValues = s.Split('-');
            var result = Convert.ToInt32(subtractValues.First());
            for (int i = 1; i < subtractValues.Length; i++)
            {
                result -= Convert.ToInt32(subtractValues[i]);
            }
            return result;
        }
    }
}