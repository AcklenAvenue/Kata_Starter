using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_3 : given_a_fizz_buzz_context
    {
        static string _result;

        Because of =
            () => _result = _fizzBuzz.Send(3);

        It should_return_fizz =
            () => _result.ShouldEqual("Fizz");
    }
}