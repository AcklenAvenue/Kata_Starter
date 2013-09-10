using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_3_5_9_10 : given_a_fizzbuzz_context
    {
        Because of =
            () => _result = _fizzBuzz.Send("3_5_9_10");

        It should_return_fizz_buzz_fizz_buzz =
            () => _result.ShouldEqual("Fizz Buzz Fizz Buzz");
    }
}