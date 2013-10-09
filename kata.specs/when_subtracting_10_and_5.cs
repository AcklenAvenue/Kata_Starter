using Machine.Specifications;

namespace kata.specs
{
    class when_subtracting_10_and_5 : given_a_calculator_context
    {
        static int _result;

        Because of = () => _result = _stringCalculator.Calculate("10-5");

        It should_return_5 = () => _result.ShouldEqual(5);
    }
}