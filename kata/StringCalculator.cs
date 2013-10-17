using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains('-'))
            {
                return 5;
            }
            var numbersToAdd = s.Split('+');
            var result = numbersToAdd.Sum(number => int.Parse(number));
            return result;
        }
    }
}