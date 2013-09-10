using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_52 : given_a_fizzbuzz_context
    {
        Because of =
            () => _result = _fizzBuzz.Send("52");

        It should_do_something =
            () => _result.ShouldEqual("Buzz");
    }
}