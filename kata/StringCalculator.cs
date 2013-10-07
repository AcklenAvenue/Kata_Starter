using System;
using System.Linq;

namespace kata
{
    public class StringCalculator  
    {
        public int Calculate(string s)
        {

            var numbers = s.Split('+');

            var result = 0;
            foreach (var number in numbers)
            {
                if (number.Contains("-"))
                    result += Subtract(number);
                else
                {
                    result += Add(number);
                }
            }
            return result;

            


                

                return Subtract(s);
            
            return Add(s);
        }

        static int Subtract(string s)
        {
            var numberToSubtract = s.Split('-').Select(x => Convert.ToInt32(x)).ToArray();


            var result = numberToSubtract.First();
            for (int i = 1; i < numberToSubtract.Count(); i++)
            {
                result -= numberToSubtract[i];
            }
            return result;
        }


        static int Add(string s)
        {
            var numbers = s.Split('+');

            return numbers.Sum(number => Convert.ToInt32(number));
        }
    }
}