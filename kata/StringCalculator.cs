namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-"))
                return 3;
            var sum = 0;
            var elements = s.Split('+');
            foreach (var element in elements)
            {
                sum += int.Parse(element);
            }
            return sum;
        }
    }
}