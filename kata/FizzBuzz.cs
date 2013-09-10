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
                if (number == "3")
                    result += "Fizz" + " ";
                else if (number == "5")
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