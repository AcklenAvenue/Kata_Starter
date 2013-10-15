using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var values = s.Split('+');
            var total = 0;
            foreach (var value in values)
            {
                if (value.Contains("-"))
                {
                    total = Substraction(value, total);
                }
                else
                {
                    total += Convert.ToInt32(value);
                }
            }

            return total;
        }

        static int Substraction(string value, int total)
        {
            var subsVals = value.Split('-');
            var result = Convert.ToInt32(subsVals.First());
            for (int i = 1; i < subsVals.Length; i++)
            {
                result -= Convert.ToInt32(subsVals[i]);
            }
            total += result;
            return total;
        }
    }
}