using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_and_subtracting_multiple_number : given_a_calc_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("-5+10+20-10-2+5");

        It should_return_18 =
            () => _result.ShouldEqual(18);
    }
}