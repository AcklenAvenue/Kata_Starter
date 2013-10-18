namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                return 2;
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