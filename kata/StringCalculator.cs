using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string value)
        {
            var operators = value.Split('+');
            var result = 0;
            foreach (var num in operators)
            {
                if (num.Contains("-"))
                {
                    result += Substract(num);
                }
                else
                {
                    result += Add(num);
                }
            }
            return result;
        }

        static int Add(string value)
        {
            string[] splitValues = value.Split('+');
            return splitValues.Sum(c => Convert.ToInt32(c));
        }

        static int Substract(string value)
        {
            string[] splitValuesToSubstract = value.Split('-');
            int substractionResult = Convert.ToInt32(splitValuesToSubstract[0]);
            for (int i = 1; i < splitValuesToSubstract.Length; i++)
            {
                substractionResult -= Convert.ToInt32(splitValuesToSubstract[i]);
            }
            return substractionResult;
        }
    }
}