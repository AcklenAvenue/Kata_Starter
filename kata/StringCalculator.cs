using System;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                if (s.Contains("+")) return 0;

                var numbersFromSubtract = s.Split('-');
                var resultFromSubtract = Convert.ToInt32(numbersFromSubtract[0]);
                for (int i = 1; i < numbersFromSubtract.Length; i++)
                {
                    resultFromSubtract -= Convert.ToInt32(numbersFromSubtract[i]);
                }
                return resultFromSubtract;
            }
            var n = s.Split('+');
            var sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += Convert.ToInt32(n[i]);
            }
            return sum;
            if (s == "5+4") return 9;
            return 16;
        }
    }
}