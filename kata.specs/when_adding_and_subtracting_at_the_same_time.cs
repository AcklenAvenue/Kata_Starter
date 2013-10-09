using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_and_subtracting_at_the_same_time : given_a_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("100-50-25+5+20+1");

        It should_return_the_sum =
            () => _result.ShouldEqual(51);
    }
}