using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_15_from_20 : given_a_calc_context
    {
        static int _result;
        Because of = () => { _result = _stringCalculator.Calculate("20-15"); };

        It should_return_5 = () => { _result.ShouldEqual(5); };
    }
}