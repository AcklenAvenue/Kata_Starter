using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_3_4_2 : given_a_string_calc_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalc.Calculate("3+4+2");

        It should_return_9 =
            () => _result.ShouldEqual(9);
    }
}