using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_4_from_10 : given_a_calculator
    {
        Because of =
            () => _result = _calculator.Calculate("10-4");

        It should_return_6 =
            () => _result.ShouldEqual(6);
    }
}