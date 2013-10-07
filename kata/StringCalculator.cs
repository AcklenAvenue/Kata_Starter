using System;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {          
            if (s.Length > 0)
            {
                string[] values = s.Split('+');
                return Convert.ToInt32(values[0]) + Convert.ToInt32(values[1]);                
            }
            return -1;
        }
    }
}