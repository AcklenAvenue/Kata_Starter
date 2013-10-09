using Machine.Specifications;

namespace kata.specs
{
    class when_substracting_3_from_6 : given_a_calc_context
    {
        static int _result;
        Because of = () => { _result = _calculator.Calculate("6-3"); };

        It should_return_3 = () => _result.ShouldEqual(3);
    }
}