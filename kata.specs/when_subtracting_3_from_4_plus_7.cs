using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_3_from_4_plus_7 : given_a_calculator
    {
        Because of =
            () => _result = _calculator.Calculate("4+7-3");

        It should_return_8 =
            () => _result.ShouldEqual(8);
    }
}