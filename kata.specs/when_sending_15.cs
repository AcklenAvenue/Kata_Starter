using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_15 : given_a_fizz_buzz_context
    {
        static string _result;

        Because of =
            () => _result = _fizzBuzz.Send(15);

        It should_return_fizzbuzz =
            () => _result.ShouldEqual("FizzBuzz");
    }
}