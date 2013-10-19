using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_10_10_from_40 : given_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _calculator.Calculate("40-10-10");

        It should_return_20 =
            () => _result.ShouldEqual(20);
    }
}