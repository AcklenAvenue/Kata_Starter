using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_30_from_15 : given_string_calculator_context
    {

        Because of =
            () => Result = Calculator.Calculate("30-15");

        It should_return_15 =
            () => Result.ShouldEqual(15);
    }
}