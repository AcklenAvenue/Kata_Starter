using System.Linq;
using System.Text.RegularExpressions;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-") && s.Contains("+"))
            {
                var items = Regex.Split(s, @"([+|-][0-9]+)");
                return items.Where(item => !item.Equals("")).Sum(item => int.Parse(item));
            }
            if (s.Contains("-"))
            {
                var subNumbers = s.Split('-');
                var result = int.Parse(subNumbers[0]);
                for (int i = 1; i < subNumbers.Length; i++)
                {
                    result -= int.Parse(subNumbers[i]);
                }
                return result;
            }
            var numbers = s.Split('+');
            return numbers.Sum(number => int.Parse(number));
        }
    }
}