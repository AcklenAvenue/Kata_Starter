using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_3_and_4_from_10_and_adding_5 : given_a_string_calculator_context
    {
        Because of =
            () => _result = _stringCalculator.Calculate("10-4-3+5");

        It should_do_something =
            () => _result.ShouldEqual(8);
    }
}