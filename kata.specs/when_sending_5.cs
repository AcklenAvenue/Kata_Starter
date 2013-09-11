using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_5 : given_a_fizz_buzz_context
    {
        static string _result;

        Because of =
            () => _result = _fizzBuzz.Send(5);

        It should_return_buzz =
            () => _result.ShouldEqual("Buzz");
    }
}