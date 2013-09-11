using Machine.Specifications;

namespace kata.specs
{
    public class when_getting_value_for_15 : given_a_fizzbuzzer_context
    {
        Because of =
            () => _result = _fizzBuzzer.Calculate(15);

        It should_return_fizzbuzz =
            () => _result.ShouldEqual("fizzbuzz");
    }
}