using Machine.Specifications;

namespace kata.specs
{
    public class given_a_fizz_buzz_context
    {
        protected static FizzBuzz _fizzBuzz;

        Establish context =
            () => { _fizzBuzz = new FizzBuzz(); };
    }
}