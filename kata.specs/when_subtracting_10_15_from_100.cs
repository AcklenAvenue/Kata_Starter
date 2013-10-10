using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_10_15_from_100 : given_a_string_calculator_context
    {
        Because of =
            () => Result = StringCalculator.Calculate("100-10-15");

        It should_return_75 =
            () => Result.ShouldEqual(75);
    }
}