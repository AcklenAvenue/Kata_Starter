using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_from_minus_1 :given_a_calculator
    {
        Because of =
            () => _result = _Calculator.Calculate("-1-2");

        It should_return_minus_3 =
            () => _result.ShouldEqual(-3);
    }
}