using Machine.Specifications;

namespace kata.specs
{
    public class when_string_is_empty : given_a_string_calculator_context
    {
        Because of =
            () => _result = StringCalculator.Calculate("");

        It should_do_something =
            () => _result.ShouldEqual(0);
    }
}