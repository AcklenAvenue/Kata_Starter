using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_10_and_20 : given_a_string_calc_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("10+20");

        It should_return_30 =
            () => _result.ShouldEqual(30);
    }
}