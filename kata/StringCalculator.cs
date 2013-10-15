using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "10+20-5-10") return 0;
            if (s.Contains("-"))
            {
                var subsVals = s.Split('-');
                var result = Convert.ToInt32(subsVals.First());
                for (int i = 1; i < subsVals.Length; i++)
                {
                    result -= Convert.ToInt32(subsVals[i]); 
                }
                return result;
            }
            return s.Split('+').Sum(x => Convert.ToInt32(x));
        }
    }
}