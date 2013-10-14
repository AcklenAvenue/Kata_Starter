using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_3_and_4 : given_a_string_calc_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalc.Calculate("3+4");

        It should_return_7 =
            () => _result.ShouldEqual(7);
    }
}