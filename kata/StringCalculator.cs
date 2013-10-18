using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains('+') && s.Contains('-'))
            {
                return 0;
            }
            if (s.Contains("-"))
            {
                string[] numbersToSubstract = s.Split('-');
                int substractResult = int.Parse(numbersToSubstract.First());
                for (int i = 1; i < numbersToSubstract.Length; i++)
                {
                    substractResult -= int.Parse(numbersToSubstract[i]);
                }
                return substractResult;
            }

            string[] numbers = s.Split('+');
            return numbers.Sum(x => int.Parse(x));
        }
    }
}