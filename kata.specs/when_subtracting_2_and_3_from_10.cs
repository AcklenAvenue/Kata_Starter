using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_and_3_from_10 :given_a_string_calculator
    {
        Because of =
            () => Result = StringCalculator.Calculate("10-2-3");

        It should_return_5 =
            () => Result.ShouldEqual(5);
    }
}