using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_3 : given_string_calculator_context
    {
        Because of =
            () => Result = Calculator.Calculate("2+3");

        It should_return_5 =
            () => Result.ShouldEqual(5);

    }
}