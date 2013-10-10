using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_7_and_3_from_20 : given_an_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("20-3-7");

        It should_return_10 =
            () => _result.ShouldEqual(10);
    }
}