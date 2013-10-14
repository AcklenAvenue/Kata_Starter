using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_5_from_7 : given_a_string_calc_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalc.Calculate("7-5");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}