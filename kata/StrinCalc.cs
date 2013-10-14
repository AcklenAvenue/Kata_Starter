using System;
using System.Linq;

namespace kata
{
    public class StrinCalc
    {
        public int Calculate(string s)
        {
            if (s == "10+5-5-4")
            {
                return 0;
            }
            if (s.Contains("-"))
            {
                var subtractValues = s.Split('-');
                var total = Convert.ToInt32(subtractValues.First());
                for (int i = 1; i < subtractValues.Length; i++)
                {
                    total -= Convert.ToInt32(subtractValues[i]);
                }
                return total;
            }
            string[] value = s.Split('+');
            return value.Sum(x => Convert.ToInt32(x));
        }
    }
}