using Machine.Specifications;

namespace kata.specs
{
    public class given_a_fizzbuzzer_context
    {
        Establish context =
            () => { _fizzBuzzer = new FizzBuzzer(); };

        protected static string _result;
        protected static FizzBuzzer _fizzBuzzer;
    }
}