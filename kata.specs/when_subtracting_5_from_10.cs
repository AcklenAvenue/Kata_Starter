using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_5_from_10 : given_an_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("10-5");

        It should_return_5 =
            () => _result.ShouldEqual(5);
    }
}