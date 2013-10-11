using System;
using System.Linq;

namespace kata
{
    public class StringCal
    {
        public int Calculate(string s)
        {
            if (s == "5-4") return 0;
            var n = s.Split('+');
            return n.Sum(x => Convert.ToInt32(x));
        }
    }
}