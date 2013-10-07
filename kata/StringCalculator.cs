using System;
using System.Linq;

namespace kata
{
    public class StringCalculator  
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                if (s.Contains("+")) return 0;

                var numberToSubtract = s.Split('-').Select(x => Convert.ToInt32(x)).ToArray();
                var result = numberToSubtract.First();
                for (int i = 1; i < numberToSubtract.Count(); i++)
                {
                    result -= numberToSubtract[i];
                }
                return result;
            }
            var numbers = s.Split('+');

            return numbers.Sum(number => Convert.ToInt32(number));
        }
    }
}