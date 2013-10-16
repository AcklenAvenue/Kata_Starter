using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_6_from_12:given_a_string_calculator_context
    {   
        Because of =
            () => Result = Calculator.Calculate("12-6");

        It should_return_6 =
            () => Result.ShouldEqual(6);
    }
}