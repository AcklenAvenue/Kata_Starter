using Machine.Specifications;

namespace kata.specs
{
    public class when_getting_value_for_6: given_a_fizzbuzzer_context
    {
        Because of =
            () => _result = _fizzBuzzer.Calculate(6);

        It should_return_fizz =
            () => _result.ShouldEqual("fizz");
    }
}