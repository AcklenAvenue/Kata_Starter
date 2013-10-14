using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_8_and_2_from_20 : given_a_string_calc_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalc.Calculate("20-2-8");

        It should_return_10 =
            () => _result.ShouldEqual(10);
    }
}