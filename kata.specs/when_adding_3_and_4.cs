using Machine.Specifications;

namespace kata.specs
{
    class when_adding_3_and_4 : given_a_calc_context
    {
        static int _result;

        Because of = () => { _result = _calculator.Calculate("3+4"); };

        It should_return_7 = () => _result.ShouldEqual(7);
    }
}