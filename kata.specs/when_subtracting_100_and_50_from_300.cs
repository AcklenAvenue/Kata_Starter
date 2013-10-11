using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_100_and_50_from_300 : given_a_calc
    {
        Because of = () => _result = _stringCalculator.Calculate("300-100-50");

        It should_return_150 = () => _result.ShouldEqual(150);
        static int _result;
    }
}