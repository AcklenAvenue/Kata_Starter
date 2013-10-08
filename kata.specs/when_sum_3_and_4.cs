using Machine.Specifications;

namespace kata.specs
{
    public class when_sum_3_and_4 : given_a_calculator
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("3+4");

        It should_return_7 =
            () => _result.ShouldEqual(7);
    }
}