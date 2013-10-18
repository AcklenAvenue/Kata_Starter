using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_3_and_substracting_it_from_10 : given_a_calc_context
    {
        Because of = () => { _result = _stringCalculator.Calculate("10-2+3"); };

        It should_return_11 = () => { _result.ShouldEqual(11); };
        static int _result;
    }
}