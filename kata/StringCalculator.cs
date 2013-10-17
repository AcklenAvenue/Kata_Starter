using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var result = 0;
            if (s.Contains('-') && s.Contains('+'))
            {
                var operators = s.Split('+');
                foreach (var @operator in operators)
                {
                    if (@operator.Contains('-'))
                    {
                        result += Substract(@operator);
                    }
                    else
                    {
                        result += int.Parse(@operator);
                    }
                }
                return result;
            }

            if (s.Contains('-'))
            {
                return Substract(s);
            }

            var numbersToAdd = s.Split('+');
            result = numbersToAdd.Sum(number => int.Parse(number));
            return result;
        }

        static int Substract(string s)
        {
            var numbersToSubstract = s.Split('-');
            var sumsub = int.Parse(numbersToSubstract.First());
            for (int i = 1; i < numbersToSubstract.Length; i++)
            {
                sumsub -= int.Parse(numbersToSubstract[i]);
            }
            return sumsub;
        }
    }
}