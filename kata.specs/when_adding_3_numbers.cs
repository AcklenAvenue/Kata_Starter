using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_3_numbers : given_string_calculator_context
    {
        
        Because of =
            () => Result = Calculator.Calculate("5+3+2");

        It should_return_10 =
            () => Result.ShouldEqual(10);
    }
}