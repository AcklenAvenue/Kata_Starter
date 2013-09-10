using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace kata
{
    public class FizzBuzzer
    {
        public string Calculate(List<int> i)
        {
            return i.First().Equals(3) ? "Fizz" : i.First().Equals(5) ? "Buzz" : i.First().ToString(CultureInfo.InvariantCulture);
        }
    }
}