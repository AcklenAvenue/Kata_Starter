namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var num = s.Split('+');
            int sum = int.Parse(num[0]) + int.Parse(num[1]);
            return sum;
                
            return 5;
        }
    }
}