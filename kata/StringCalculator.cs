using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var result = 0;
            if(s.Contains('-') && s.Contains('+'))
                return 0;
            if (s.Contains("-"))
            {
                
                var substract = s.Split('-');
                result = Convert.ToInt32(substract[0]);
                for (int i = 1; i < substract.Length; i++)
                {
                    result -= Convert.ToInt32(substract[i]);
                }
            }else
            {
                result = s.Split('+').Sum(x => Convert.ToInt32(x));
            }
            return result;
        }
    }
}