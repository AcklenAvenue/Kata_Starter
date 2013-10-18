using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_10_20_and_subtracting_15: given_a_string_calculator_conext
    {
        Because of =
            () => Result = StringCalculator.Calculate("10+20-15");

        It should_return_15 =
            () => Result.ShouldEqual(15);
    }
}