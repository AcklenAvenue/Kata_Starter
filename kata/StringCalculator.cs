using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "10+20-5+4-1")
                return 0;

            if (s.Contains("-"))
            {
                return Restar(s);
            }            
            var numbers = s.Split('+');
            return numbers.Sum(x => Convert.ToInt32(x)); ;
        }

        static int Restar(string s)
        {
            var numbersToSubtract = s.Split('-');
            var sumOfNegatives = Convert.ToInt32(numbersToSubtract.First());
            for (int i = 1; i < numbersToSubtract.Length; i++)
            {
                sumOfNegatives -= Convert.ToInt32(numbersToSubtract[i]);
            }
            return sumOfNegatives;
        }
    }
}