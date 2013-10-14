using System;
using System.Runtime.InteropServices;
using System.Text;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                return 0;
            }
            var numbers = s.Split('+');
            int result = 0;
            foreach (var number in numbers)
            {
                int n = int.Parse(number);
                result += n;   
                
            }
            return result;
        }
    }
}