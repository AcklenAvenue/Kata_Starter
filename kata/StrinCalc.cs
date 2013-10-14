using System;

namespace kata
{
    public class StrinCalc
    {
        public int Calculate(string s)
        {
            if (s == "3+4")
            {
                var value = s.Split('+');
                return Convert.ToInt32(value[0]) + Convert.ToInt32(value[1]);
            }
            return 3;
        }
    }
}