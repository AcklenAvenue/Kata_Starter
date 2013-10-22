using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_from_3_plus_5 : given_a_calculator
    {
        Because of =
            () => _result = _calculator.Calculate("3+5-2");

        It should_return_6 =
            () => _result.ShouldEqual(6);
    }
}