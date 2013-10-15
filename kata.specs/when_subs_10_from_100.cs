using Machine.Specifications;

namespace kata.specs
{
    public class when_subs_10_from_100 : given_calculator_context
    {

        Because of = () => _result = _calculator.Calculate("100-10");

        It should_return_90 = () => _result.ShouldEqual(90);
    }
}