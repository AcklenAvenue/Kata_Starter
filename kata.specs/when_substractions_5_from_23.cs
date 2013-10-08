using Machine.Specifications;

namespace kata.specs
{
    public class when_substractions_5_from_23 : given_a_string_calc_context
    {
        Because of =
            () => _result = _stringCalculator.Calculate("23-5");

        It should_return_18 =
            () => _result.ShouldEqual(18);

        static int _result;
    }
}