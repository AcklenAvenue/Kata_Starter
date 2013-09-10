namespace kata
{
    public class FizzBuzzer
    {
        //dice javier que esta funcioncita es fea :(
        public string CalculateAll()
        {
            var returnValue = "";
            for (int i = 1; i <= 100; i++)
               returnValue += Calculate(i);
            return returnValue;
        }

        public string Calculate(int i)
        {
            if (i.Equals(3))
                return "Fizz";

            return "Buzz";
        }
    }
}