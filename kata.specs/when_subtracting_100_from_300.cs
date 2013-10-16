using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_100_from_300 : given_a_calc_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("300-100");

        It should_return_200 =
            () => _result.ShouldEqual(200);
    }
}