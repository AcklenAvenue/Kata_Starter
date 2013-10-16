using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-") && s.Contains("+"))
            {
                var item = Regex.Split(s, @"([+|-][0-9]+)");
                var total = item.Where(s1 => !s1.Equals("")).Sum(s1 => int.Parse(s1));
                return total;
            }
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