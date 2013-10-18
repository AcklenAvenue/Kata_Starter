using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_4_and_5_from_11 : given_a_calc_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("11-4-5");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}