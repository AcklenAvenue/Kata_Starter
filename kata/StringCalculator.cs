using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                if (s.Contains("+")) return 0;

                var num = s.Split('-');
                var result = int.Parse(num[0]);
                for (int i = 1; i < num.Length; i++)
                {
                    result -= int.Parse(num[i]);
                }
                return result;
            }
            
            var number =  s.Split('+');
            return number.Sum(num => int.Parse(num));

        }
    }
}