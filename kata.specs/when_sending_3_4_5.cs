using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_3_4_5 : given_a_fizzbuzz_context
    {
        static string _result;

        Because of =
            () => _result = _fizzBuzz.Send("3_4_5");

        It should_return_fizz_4_buzz =
            () => _result.ShouldEqual("Fizz 4 Buzz");
    }
}