using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_from_4 : given_a_string_calculator_context
    {
        Because of =
            () => Result = StringCalculator.Calculate("4-2");

        It should_return_2 =
            () => Result.ShouldEqual(2);
    }
}