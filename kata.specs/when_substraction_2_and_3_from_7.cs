using Machine.Specifications;

namespace kata.specs
{
    public class when_substraction_3_from_7 : given_a_string_calculator_context
    {
        Because of =
            () => Result = StringCalculator.Calculate("7-3");

        It should_return_2=
            () => Result.ShouldEqual(4);
    }
}