using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_10_from_15 : given_string_calculator_context
    {
        Because of = () => { Result = Calculator.Calculate("15-10"); };

        It should_return_5 = () => Result.ShouldEqual(5);
    }
}