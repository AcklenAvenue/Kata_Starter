using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {    
            var numbers = s.Split('+');
            var total = 0;
            foreach (var number in numbers)
            {
                if (number.Contains("-"))
                {
                    total = Substract(number, total);
                }
                else
                {
                    total += Convert.ToInt32(number);
                }
            }

            return total;
        }

        static int Substract(string number, int total)
        {
            var valuesToSubstract = number.Split('-');
            var result = Convert.ToInt32(valuesToSubstract.First());
            for (var i = 1; i < valuesToSubstract.Length; i++)
            {
                result -= Convert.ToInt32(valuesToSubstract[i]);
            }
            total += result;
            return total;
        }
    }
}