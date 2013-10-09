using Machine.Specifications;

namespace kata.specs
{
    class when_substracting_3_from_6_and_adding_it_to_10 : given_a_calc_context
    {
        static int _result;
        Because of = () => { _result = _calculator.Calculate("6-3+10"); };

        It should_return_13 = () => _result.ShouldEqual(13);
    }
}