using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_1 : given_a_fizz_buzz_context
    {
        static string _result;

        Because of =
            () => _result = _fizzBuzz.Send(1);

        It should_return_1 =
            () => _result.ShouldEqual("1");
    }
}