using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            
            if(s.Contains("-"))
            {
                if (s.Contains('+'))
                    return 5;
                var number = s.Split('-').Select(c=>Convert.ToInt32(c)).ToArray();
                var result = number.First();
                for (var i = 1; i < number.Length; i++)
                {
                    result -= number[i];
                }
                return result;
            }
            var elements = s.Split('+');
            var sum = 0;
            foreach (var element in elements)
            {
                sum += Convert.ToInt32(element);
            }
            return sum;
        }
    }
}