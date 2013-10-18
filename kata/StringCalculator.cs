using System.Linq;
using System.Text.RegularExpressions;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var numbers = Regex.Split(s,@"([-|+][0-9]+)");

            return numbers.Where(number => !number.Equals("")).Sum(number => int.Parse(number));

            if (s.Contains("-") && s.Contains("+"))
                return 0;
            if (s.Contains("-"))
            {
                var nums = s.Split('-');
                var res = int.Parse(nums[0]);
                for (int i = 1; i < nums.Length; i++)
                {
                    res -= int.Parse(nums[i]);
                }
                return res; 
            }
            if(s.Contains("+"))
            {
                var sum = 0;
                var nums = s.Split('+');
                foreach (var num in nums)
                {
                    sum += int.Parse(num);
                    
                }
                return sum;
            }
            return 0;
        }
    }
}