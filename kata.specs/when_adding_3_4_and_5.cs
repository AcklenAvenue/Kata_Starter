using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_3_4_and_5 : given_a_calc_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("3+4+5");

        It should_return_12 =
            () => _result.ShouldEqual(12);
    }
}