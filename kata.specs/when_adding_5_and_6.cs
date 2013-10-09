using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_5_and_6 : given_a_calc_context
    {
        static int _result;

        Because of =
            () => _result = _calculator.Calculate("5+6");

        It should_return_11 =
            () => _result.ShouldEqual(11);
    }
}