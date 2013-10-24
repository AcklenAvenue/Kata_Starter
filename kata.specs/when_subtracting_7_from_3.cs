using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_7_from_3 : given_a_calculator
    {
        Because of =
            () => _result = _calculator.Calculate("3-7");

        It should_return_minus_4 =
            () => _result.ShouldEqual(-4);
    }
}