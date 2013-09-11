namespace kata
{
    public class FizzBuzzer
    {
        public string Calculate(int number)
        {
            return number % 3 == 0 ? "fizz" 
                : number % 5  == 0? "buzz" : number.ToString();
        }
    }
}