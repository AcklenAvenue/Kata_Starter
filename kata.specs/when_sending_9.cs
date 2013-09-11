using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_9 : given_a_fizz_buzz_context
    {
        static string _result;

        Because of =
            () => _result = _fizzBuzz.Send(9);

        It should_return_Fizz =
            () => _result.ShouldEqual("Fizz");
    }
}