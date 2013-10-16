using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_1_and_2_from_5:given_a_string_calculator_context
    {
        Because of =
            () => Result = Calculator.Calculate("5-1-2");

        It should_return_2 =
            () => Result.ShouldEqual(2);
    }
}