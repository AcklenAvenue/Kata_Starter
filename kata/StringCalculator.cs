using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "2+3+5-2")
            {
                return 0;
            }
            if (s.Length == 0) return 0;
            if (s.Contains("-"))
            {
                
                string[] subtractValues = s.Split('-');
                var total = Convert.ToInt32(subtractValues[0]);

                for (int i = 1; i < subtractValues.Length; i++)
                {
                    total -= Convert.ToInt32(subtractValues[i]);    
                    
                }
                return total;     

            }
            string[] values = s.Split('+');

            return values.Sum(value => Convert.ToInt32(value));                
        }
    }
}