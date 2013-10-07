using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var numbers = s.Split('+');
            var totalSum = 0;
            foreach (var number in numbers)
            {
                if (number.Contains("-"))
                {
                    totalSum += Restar(number);
                }
                else
                {
                    totalSum += Convert.ToInt32(number);
                }
            }
            return totalSum;
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