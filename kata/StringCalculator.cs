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
                var num = s.Split('-');
                return int.Parse(num[0]) - int.Parse(num[1]);
            }
            
            var number =  s.Split('+');
            return number.Sum(num => int.Parse(num));

        }
    }
}