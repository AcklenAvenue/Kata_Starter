using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_10_and_5_from_30 : given_a_string_calc_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("30-5-10");

        It should_return_15 =
            () => _result.ShouldEqual(15);
    }
}