using Machine.Specifications;

namespace kata.specs
{
    public class when_sub_three_numbers : given_a_string_calculator_context
    {
        Because of =
            () => _result = _calculator.Calculate("100-1-2");

        It should_return_97 =
            () => _result.ShouldEqual(97);
    }
}