using Machine.Specifications;

namespace kata.specs
{
    public class given_a_fizzbuzzer_context
    {
        protected static FizzBuzzer _fizzbuzzer;

        Establish context =
            () => { _fizzbuzzer = new FizzBuzzer(); };
    }
}