using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_from_5 :given_calculator_context
    {
        Because of =
            () => _result = _stringCalculator.Calculate("5-2");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}