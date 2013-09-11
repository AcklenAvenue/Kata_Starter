using Machine.Specifications;

namespace kata.specs
{
    public class when_getting_value_for_10 : given_a_fizzbuzzer_context
    {
        Because of =
            () => _result = _fizzBuzzer.Calculate(10);

        It should_do_something =
            () => _result.ShouldEqual("buzz");
    }
}