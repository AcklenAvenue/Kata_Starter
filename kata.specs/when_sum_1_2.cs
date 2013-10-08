using Machine.Specifications;

namespace kata.specs
{
    public class when_sum_1_2 : given_a_calculator
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("1+2");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}