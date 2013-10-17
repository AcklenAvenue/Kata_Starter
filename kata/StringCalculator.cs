using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains('-') && s.Contains('+'))
            {
                return 0;
            }

            if (s.Contains('-'))
            {
                var numbersToSubstract = s.Split('-');
                var sumsub = int.Parse(numbersToSubstract.First());
                for (int i = 1; i < numbersToSubstract.Length; i++)
                {
                    sumsub -= int.Parse(numbersToSubstract[i]);
                }
                return sumsub;
            }
            var numbersToAdd = s.Split('+');
            var result = numbersToAdd.Sum(number => int.Parse(number));
            return result;
        }
    }
}