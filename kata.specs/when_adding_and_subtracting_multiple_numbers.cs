using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_and_subtracting_multiple_numbers : given_a_calc_context
    {
        static int _result;

        Because of = () => { _result = _stringCalculator.Calculate("10-5-5+10+10"); };

        It should_return_20 = () => _result.ShouldEqual(20);
    }
}