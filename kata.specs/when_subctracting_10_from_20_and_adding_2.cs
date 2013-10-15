using Machine.Specifications;

namespace kata.specs
{
    public class when_subctracting_10_from_20_and_adding_2 : given_a_string_calculator_context
    {
        Because of =
            () => _result = _calculator.Calculate("20-10+2");

        It should_return_12 =
            () => _result.ShouldEqual(12);
    }
}