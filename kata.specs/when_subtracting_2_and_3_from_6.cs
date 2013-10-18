using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_and_3_from_6:given_a_string_calculator_conext
    {
        Because of =
            () => Result = StringCalculator.Calculate("6-2-3");

        It should_return_1 =
            () => Result.ShouldEqual(1);
    }
}