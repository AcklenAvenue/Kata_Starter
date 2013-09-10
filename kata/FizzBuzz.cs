using System;
using System.Collections.Generic;

namespace kata
{
    public class FizzBuzz
    {
        public string Send(string values)
        {
            string[] numbers = values.Split('_');
            string result = string.Empty;

            foreach (var number in numbers)
            {
                if (Convert.ToInt32(number)%3 == 0 || number.Contains("3"))
                {
                    result += "Fizz" + " ";
                }
                else if (Convert.ToInt32(number)%5 == 0)
                {
                    result += "Buzz" + " ";
                }
                else
                {
                    result += number + " ";
                }
            }

            return result.Trim();
        }
    }
}