using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_10_from_50 : given_a_calculator
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("50-10");

        It should_return_40 =
            () => _result.ShouldEqual(50);
    }
}