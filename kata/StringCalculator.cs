using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            string[] numbers = s.Split('+');
            int resultado = 0;
            foreach (string number in numbers)
            {
                if (s.Contains("-"))
                {
                    resultado += Subtract(number);
                }
                else
                {
                    resultado += Add(number);
                }
            }

            return resultado;
        }

        static int Subtract(string s)
        {
            string[] subtractValues = s.Split('-');
            int total = Convert.ToInt32(subtractValues.First());

            for (int i = 1; i < subtractValues.Length; i++)
            {
                total -= Convert.ToInt32(subtractValues[i]);
            }
            return total;
        }

        static int Add(string s)
        {
            string[] numbers = s.Split('+');
            return numbers.Sum(number => Convert.ToInt32(number));
        }
    }
}