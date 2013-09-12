using Machine.Specifications;

namespace kata.specs
{
    public class given_a_fizzbuzz_context
    {
        protected static FizzBuzzer _fizzbuzzer;

        Establish context =
            () => { _fizzbuzzer = new FizzBuzzer(); };
    }
}