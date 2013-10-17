using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_multiple_numbers :given_a_calculator
    {
        Because of =
            () => _result = _calculator.Calculate("1-10-3");

        It should_return_minus_12 =
            () => _result.ShouldEqual(-12);
    }
}