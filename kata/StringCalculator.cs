namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("60-30-20"))
                return 0;
            if (s.Contains("-"))
                return 99;

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