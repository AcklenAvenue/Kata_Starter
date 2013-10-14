using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_from_5 :given_a_string_calculator
    {
        Because of =
            () => Result = StringCalculator.Calculate("5-2");

        It should_return =
            () => Result.ShouldEqual(3);
    }
}