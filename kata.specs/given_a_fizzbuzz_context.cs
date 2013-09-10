using Machine.Specifications;

namespace kata.specs
{
    public class given_a_fizzbuzz_context
    {
        protected static FizzBuzz _fizzBuzz;
        protected static string _result;
        Establish context =
            () => { _fizzBuzz = new FizzBuzz(); };
    }
}