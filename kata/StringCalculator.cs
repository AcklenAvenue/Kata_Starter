namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var numbers = s.Split('+');
            return int.Parse(numbers[0]) + int.Parse(numbers[1]);
        }
    }
}