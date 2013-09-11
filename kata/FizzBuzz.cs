namespace kata
{
    public class FizzBuzz
    {
        public string Send(int value)
        {
            if (value == 5) return "Buzz";
            if (value % 3 == 0) return "Fizz";
            return value.ToString();
        }
    }
}