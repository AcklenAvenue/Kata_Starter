using System;

namespace kata
{
    public class FizzBuzzer
    {
        public string GetValue(int i)
        {
            if (i == 3) return "fizz";
            return i.ToString();
        }
    }
}