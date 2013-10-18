using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_10_from_11 : given_a_calc_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("11-10");

        It should_return_1 =
            () => _result.ShouldEqual(1);
    }
}