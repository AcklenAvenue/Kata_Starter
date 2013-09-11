using Machine.Specifications;

namespace kata.specs
{
    public class when_getting_value_for_1 : given_a_fizzbuzzer_context
    {
        Because of =
            () => _result = _fizzBuzzer.Calculate(1);

        It should_do_something =
            () => _result.ShouldEqual("1");
    }
}