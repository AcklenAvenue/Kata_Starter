using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_4 : given_a_fizz_buzz_context
    {
        static string _result;

        Because of =
            () => _result = _fizzBuzz.Send(4);

        It should_return_4 =
            () => _result.ShouldEqual("4");
    }
}