using Machine.Specifications;

namespace kata.specs
{
    public class given_a_fizzbuzz_controller
    {
        public static FizzBuzzer _fizzBuzzer;

        Establish context =
            () =>
                {
                    _fizzBuzzer = new FizzBuzzer();
                };
    }
}