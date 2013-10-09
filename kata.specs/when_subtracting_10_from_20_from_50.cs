using Machine.Specifications;

namespace kata.specs
{
    class when_subtracting_10_from_20_from_50 : given_a_calculator_context
    {
        static int _result;

        Because of = () => _result = _stringCalculator.Calculate("50-20-10");

        It should_return_20 = () => _result.ShouldEqual(20);
    }
}