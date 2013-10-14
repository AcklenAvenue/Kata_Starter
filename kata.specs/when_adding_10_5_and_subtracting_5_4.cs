using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_10_5_and_subtracting_5_4 : given_a_string_calc_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalc.Calculate("10+5-5-4");

        It should_return_6 =
            () => _result.ShouldEqual(6);
    }
}