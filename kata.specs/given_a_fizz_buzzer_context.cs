using Machine.Specifications;

namespace kata.specs
{
    public class given_a_fizz_buzzer_context
    {
        public static IFizzBuzer FizzBuzzer;

        Establish context = () =>
            {
                FizzBuzzer = new FizzBuzer(3, 5, "fizz", "buzz");
            };
    }
}