using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_multiple_numbers : given_a_calculator_context
    {
        Because of =
            () => _result = _calculator.Calculate("3-2-1");

        It should_return_0 =
            () => _result.ShouldEqual(0);
    }
}