using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_3 : given_a_fizzbuzz_context
    {
        Because of =
            () => _result = _fizzBuzz.Send("3");

        It should_return_the_word_fizz =
            () => _result.ShouldEqual("Fizz");
    }
}