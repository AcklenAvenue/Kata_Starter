using System;

namespace kata
{
    public class FizzBuzzer
    {
        public string GetValue(int i)
        {
            if (i == 3) return "fizz";
            if (i == 5) return "buzz";
            return i.ToString();
        }
    }
}