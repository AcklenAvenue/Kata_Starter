using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_from_10:given_a_string_calculator_conext
    {
        Because of =
            () => Result = StringCalculator.Calculate("10-2");

        It should_return_8 =
            () => Result.ShouldEqual(8);
    }
}