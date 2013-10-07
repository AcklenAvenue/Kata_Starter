namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {

            var result = 0;
            if(s.Contains("+") && s.Contains("-"))
            {
                return 0;
            }
            if (s.Contains("+"))
            {
                var numbers = s.Split('+');
                foreach (var number in numbers)
                {
                    result += int.Parse(number);
                }
            }else
            {
                var numbers = s.Split('-');
                result = int.Parse(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    result -= int.Parse(numbers[i]);
                }
            }
            return result;
        }
    }
}