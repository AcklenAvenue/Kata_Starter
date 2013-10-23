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
                    total += Substract(number);
                }
                else
                {
                    total += Convert.ToInt32(number);
                }
            }
            
            return  total;
        }

        static int Substract(string s)
        {
            var numSubs = s.Split('-').Select(c => Convert.ToInt32(c)).ToArray();
            var result = numSubs[0];

            for (int i = 1; i < numSubs.Length; i++)
            {
                result -= numSubs[i];
            }

            return result;
        }
    }
}