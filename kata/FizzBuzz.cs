using System;
using System.Collections.Generic;

namespace kata
{
    public class FizzBuzz : IFizzBuzz
    {
        readonly string _buzzLabel = "Buzz";
        readonly string _fizzNumber;
        readonly string _buzzNumber;
        readonly string _fizzLabel = "Fizz";
        readonly char _separator = '_';

        public FizzBuzz(string fizzLabel, string buzzLabel , string fizzNumber, string buzzNumber, char separator)
        {
            _fizzLabel = fizzLabel;
            _buzzLabel = buzzLabel;
            _fizzNumber = fizzNumber;
            _buzzNumber = buzzNumber;
            _separator = separator;
        }

        public string Send(string values)
        {
            string[] numbers = values.Split(_separator);
            string result = string.Empty;

            foreach (var number in numbers)
            {
                if (IsFizzNumber(number) && IsBuzzNumber(number))
                {
                    result += _fizzLabel + _buzzLabel + " ";
                }
                else if (IsFizzNumber(number))
                {
                    result += _fizzLabel + " ";
                }
                else if (IsBuzzNumber(number))
                {
                    result += _buzzLabel + " ";
                }
                else
                {
                    result += number + " ";
                }
            }

            return result.Trim();
        }

        bool IsFizzNumber(string number)
        {
            return IsDivisibleByFizzNumber(number) || ContainsFizzNumber(number);
        }

        bool IsBuzzNumber(string number)
        {
            return IsDivisibleByBuzzNumber(number) || ContainsBuzzNumber(number);
        }

        bool ContainsFizzNumber(string number)
        {
            return number.Contains(_fizzNumber);
        }

        bool IsDivisibleByFizzNumber(string number)
        {
            return Convert.ToInt32(number)%Convert.ToInt32(_fizzNumber) == 0;
        }

        bool ContainsBuzzNumber(string number)
        {
            return number.Contains(_buzzNumber);
        }

        bool IsDivisibleByBuzzNumber(string number)
        {
            return Convert.ToInt32(number)%Convert.ToInt32(_buzzNumber) == 0;
        }
    }
}