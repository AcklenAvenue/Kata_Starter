namespace kata
{
    public class FizzBuzzer
    {
        public string Calculate(int number)
        {
            return number == 3 ? "fizz" 
                : number == 5 ? "buzz" : number.ToString();
        }
    }
}