namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
            {
                return 0;
            }
            var numbers = s.Split('+');
            var result = 0;
            foreach (var number in numbers)
            {
                 result += int.Parse(number);
            }

            return result;
        }
    }
}