using System;
using System.Linq;

namespace kata
{
    public class Calculator
    {
        public int Calculate(string s)
        {

            var numbers = s.Split('+');
            var total = 0;
            foreach (var number in numbers)
            {
                if (number.Contains("-"))
                {
                    total = Substract(number, total);
                }
                else
                {
                    total += Convert.ToInt32(number);
                }
            }
            return total;
        }

        static int Substract(string number, int total)
        {
            var subs = number.Split('-');
            var result = Convert.ToInt32(subs.First());
            for (int i = 1; i < subs.Length; i++)
            {
                result -= Convert.ToInt32(subs[i]);
            }
            total += result;
            return total;
        }
    }
}