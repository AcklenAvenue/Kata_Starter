using Machine.Specifications;

namespace kata.specs
{
    public class when_subctract_and_sum_10_20_5_3 : given_a_calculator
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("10+20-5-3");

        It should_return_22 =
            () => _result.ShouldEqual(22);
    }
}