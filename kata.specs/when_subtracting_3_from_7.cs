using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_3_from_7:given_a_string_calculator
    {
        Because of =
            () => Result = StringCalculator.Calculate("7-3");

        It should_return_4 =
            () => Result.ShouldEqual(4);
    }
}