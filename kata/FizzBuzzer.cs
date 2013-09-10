using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace kata
{
    public class FizzBuzzer
    {
        public string Calculate(List<int> numbers)
        {
            var returnValue = "";
            foreach (var number in numbers)
            {
                returnValue += (number % 3 == 0 && number % 5 == 0) ? "FizzBuzz": number % 3 == 0 ? "Fizz" : number % 5 == 0 ? "Buzz" : number.ToString(CultureInfo.InvariantCulture);
                returnValue += " ";
            }
            return returnValue.Remove(returnValue.Length - 1);
        }
    }
}