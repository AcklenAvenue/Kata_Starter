using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_and_4_from_10 : given_a_calculator
    {
        Because of =
            () => _result = _calculator.Calculate("10-4-2");

        It should_return_4 =
            () => _result.ShouldEqual(4);
    }
}