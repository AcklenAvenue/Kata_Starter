using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_4_and_4_and_6 : given_a_calc_context
    {
        static int _result;
        Because of = () => { _result = _stringCalculator.Calculate("4+4+6"); };

        It should_return_14 = () => _result.ShouldEqual(14);
    }
}