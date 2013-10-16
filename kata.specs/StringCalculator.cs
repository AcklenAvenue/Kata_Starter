using System;
using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                var subsValues = s.Split('-');
                var result = Convert.ToInt32(subsValues.First());
                for (int i = 1; i < subsValues.Length; i++)
                {
                    result -= Convert.ToInt32(subsValues[i]);
                }
                return result;
            }

            var numbers = s.Split('+');
            return numbers.Sum(number => int.Parse(number));
        }
    }
}