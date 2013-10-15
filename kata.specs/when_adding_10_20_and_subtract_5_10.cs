using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_10_20_and_subtract_5_10 : given_context_string_calculator
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("10+20-5-10");

        It should_return_15 =
            () => _result.ShouldEqual(15);
    }
}