using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_1_and_2_from_6:given_a_string_calculator_context
    {
        Because of =
            () => Result = StringCalculator.Calculate("6-2-1");

        It should_return_3 =
            () => Result.ShouldEqual(3);
    }
}