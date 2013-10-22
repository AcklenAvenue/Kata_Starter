using Machine.Specifications;

namespace kata.specs
{
    public class when_subtrating_1_from_10:given_a_string_calculator_context
    {
        Because of =
            () => Result = StringCalculator.Calculate("10-1");

        It should_return_9 =
            () => Result.ShouldEqual(9);
    }
}