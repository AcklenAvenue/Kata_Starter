using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_4_from_8 : given_a_string_calc_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalc.Calculate("8-4");

        It should_return_4 =
            () => _result.ShouldEqual(4);
    }
}