using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_3_5_12_13_15_52_53: given_a_fizzbuzz_context
    {
        Because of =
            () => _result = _fizzBuzz.Send("3_5_12_13_15_52_53");

        It should_return_fizz_buzz_fizz_fizz_fizzbuzz_buzz_fizzbuzz =
            () => _result.ShouldEqual("Fizz Buzz Fizz Fizz FizzBuzz Buzz FizzBuzz");
    }
}