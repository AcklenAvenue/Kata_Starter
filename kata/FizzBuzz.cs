﻿namespace kata
{
    public interface IFizzBuzz
    {
        string Send(int value);
    }

    public class FizzBuzz : IFizzBuzz
    {
        public string Send(int value)
        {
            if (value%3 == 0 && value % 5 == 0) return "FizzBuzz";
            if (value%5 == 0) return "Buzz";
            if (value%3 == 0) return "Fizz";
            return value.ToString();
        }
    }
}