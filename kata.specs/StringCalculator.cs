using System;
using System.Linq;

namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {

            var values = s.Split('+');
            var globalTotal = 0;
            foreach (var value in values)
            {
                if (value.Contains("-"))
                {
                    var rest = value.Split('-');
                    var total = Convert.ToInt32(rest.First());
                    for (int i = 1; i < rest.Length; i++)
                    {
                        total -= int.Parse(rest[i]);
                    }
                    globalTotal += total;
                }
                else
                {
                    globalTotal += Convert.ToInt32(value);
                }
            }
            return globalTotal;
        }
    }
}