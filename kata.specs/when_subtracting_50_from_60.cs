using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_50_from_60 : given_a_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("60-50");

        It should_return_10 =
            () => _result.ShouldEqual(10);
    }
}