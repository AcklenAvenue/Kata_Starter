using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_2_from_3_from_10 : given_string_calculator_context
    {

        Because of = () => { Result = Calculator.Calculate("10-3-2"); };

        It should_return_5 = () => Result.ShouldEqual(5);
    }
}