namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {

            var result = 0;
            if (s.Contains("+"))
            {
                var numbers = s.Split('+');
                foreach (var number in numbers)
                {
                    result += int.Parse(number);
                }
            }else
            {
                return 0;
            }
            return result;
        }
    }
}