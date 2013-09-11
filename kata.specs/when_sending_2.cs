using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_2 : given_a_fizz_buzz_context
    {
        static string _result;

        Because of =
            () => _result = _fizzBuzz.Send(2);

        It should_return_2 =
            () => _result.ShouldEqual("2");
    }
}