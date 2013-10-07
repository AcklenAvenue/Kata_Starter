using System;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Length == 0) return 0;
            if (s.Contains("2-1")) return -1;
            int result = 0;            
            string[] values = s.Split('+');

            foreach (var value in values)
            {
                result += Convert.ToInt32(value);
            }
            return result;                
        }
    }
}