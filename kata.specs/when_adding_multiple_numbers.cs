using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_multiple_numbers : given_a_string_calculator_context
    {
        Because of =
            () => _result = _calculator.Calculate("1+2+3");

        It should_the_expected_result =
            () => _result.ShouldEqual(6);
    }
}