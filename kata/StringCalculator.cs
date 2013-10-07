using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Length == 0) return 0;

            string[] values = s.Split('+');
            int result = 0;
            foreach (var numberString in values)
            {
                if (numberString.Contains("-"))
                {
                    result += Substract(numberString);
                }
                else
                {
                    result += Convert.ToInt32(numberString);
                }
            }

            return result;                
        }

        static int Substract(string s)
        {
            string[] subtractValues = s.Split('-');
            var total = Convert.ToInt32(subtractValues[0]);

            for (int i = 1; i < subtractValues.Length; i++)
            {
                total -= Convert.ToInt32(subtractValues[i]);
            }
            return total;
        }
    }
}