namespace kata
{
    public class FizzBuzzer
    {
        public string GetValue(int i)
        {
            if (i % 3 == 0 && i % 5 == 0) return "FizzBuzz";
            if (i % 3 == 0) return "Fizz";
            if (i % 5 == 0) return "Buzz";
            
            return i.ToString();
        }
    }
}