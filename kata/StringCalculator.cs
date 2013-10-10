using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string value)
        {
            if (value.Contains('+') && value.Contains('+'))
            {
                return 0;
            }
            if (value.Contains("-"))
            {
                var splitValuesToSubstract = value.Split('-');
                var substractionResult = Convert.ToInt32(splitValuesToSubstract[0]);
                for (var i = 1; i < splitValuesToSubstract.Length; i++ )
                {
                    substractionResult -= Convert.ToInt32(splitValuesToSubstract[i]);
                }
                return substractionResult;
            }
                
            var splitValues = value.Split('+');
            return splitValues.Sum(c => Convert.ToInt32(c));
        }
    }
}