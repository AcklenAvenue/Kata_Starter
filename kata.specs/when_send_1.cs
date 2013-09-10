using Machine.Specifications;

namespace kata.specs
{
    public class when_send_1:given_a_fizzbuzz_context
    {
        Because of =
            () => _result = _fizzBuzz.Send("1");

        It should_return_1 =
            () => _result.ShouldEqual("1");
    }
}