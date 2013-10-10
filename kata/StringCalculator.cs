using System;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string value)
        {
            var splitValues = value.Split('+');
            return Convert.ToInt32(splitValues[0]) + Convert.ToInt32(splitValues[1]);
        }
    }
}