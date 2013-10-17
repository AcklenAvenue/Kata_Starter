using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains('-'))
            {
                var numbersToSubstract = s.Split('-');
                return int.Parse(numbersToSubstract[0]) - int.Parse(numbersToSubstract[1]);
            }
            var numbersToAdd = s.Split('+');
            var result = numbersToAdd.Sum(number => int.Parse(number));
            return result;
        }
    }
}