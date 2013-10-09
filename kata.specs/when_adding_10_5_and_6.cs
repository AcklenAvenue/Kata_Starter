using Machine.Specifications;

namespace kata.specs
{
    class when_adding_10_5_and_6 : given_a_calc_context
    {
        static int _result;
        Because of = () => _result = _calculator.Calculate("10+5+6");

        It should_return_21 = () => _result.ShouldEqual(21);
    }
}