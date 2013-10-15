using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_9_and_6 : given_calculator_context
    {
        Because of = () => _result = _calculator.Calculate("9+6");

        It should_return_15 = () => _result.ShouldEqual(15);
    }
}