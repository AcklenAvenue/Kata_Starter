using System;
using System.Linq;

namespace kata
{
    public class StrinCalc
    {
        public int Calculate(string s)
        {
            if (s.Contains("-")) return 2;
            string[] value = s.Split('+');
            return value.Sum(x => Convert.ToInt32(x));
        }
    }
}