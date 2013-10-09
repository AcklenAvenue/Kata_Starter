using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_5_and_6_from_12 : given_a_calc_context
    {
        static int _result;

        Because of =
            () => _result = _calculator.Calculate("12-6-5");

        It should_return_1 =
            () => _result.ShouldEqual(1);
    }
}