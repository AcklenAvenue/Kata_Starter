using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_10 : given_a_fizz_buzz_context
    {
        static string _result;

        Because of =
            () => _result = _fizzBuzz.Send(10);

        It should_return_Buzz =
            () => _result.ShouldEqual("Buzz");
    }
}