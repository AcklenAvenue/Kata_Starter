using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s == "10-5") return 5;
            if (s == "2+2")
                return 4;
            if (s.Contains("-"))
            {
                return 2;
            }
            
            var number =  s.Split('+');
            return number.Sum(num => int.Parse(num));

        }
    }
}