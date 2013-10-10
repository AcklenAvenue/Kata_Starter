using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var values = s.Split('+');
            var globalResult = 0;
            foreach (var value in values)
            {
                if (value.Contains('-'))
                {
                    globalResult += Substract(value);
                }
                else
                {
                    globalResult += Convert.ToInt32(value);
                }
            }
            return globalResult;
        }

        static int Substract(string s)
        {
            var valuesSubstracting = s.Split('-');
            var result = Convert.ToInt32(Enumerable.First<string>(valuesSubstracting));
            for (int i = 1; i < valuesSubstracting.Length; i++)
            {
                result -= Convert.ToInt32((string) valuesSubstracting[i]);
            }
            return result;
        }
    }
}