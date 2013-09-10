using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_3_4_5_6:given_a_fizzbuzz_context
    {
        Because of =
            () => _result = _fizzBuzz.Send("3_4_5_6");

        It should_return_fizz_4_buzz_fizz =
            () => _result.ShouldEqual("Fizz 4 Buzz Fizz");
    }
}