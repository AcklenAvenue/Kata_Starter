using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_5_from_10 : given_a_string_calculator_context
    {
        Because of = () => _result = _stringCalculator.Calculate("10-5");

        It should_return_5 = () => _result.ShouldEqual(5);
    }
}