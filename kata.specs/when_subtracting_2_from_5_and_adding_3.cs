using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_from_5_and_adding_3 : given_a_string_calculator_context
    {
        Because of =
            () => Result = Calculator.Calculate("5-2+3");

        It should_return_6 =
            () => Result.ShouldEqual(6);
    }
}