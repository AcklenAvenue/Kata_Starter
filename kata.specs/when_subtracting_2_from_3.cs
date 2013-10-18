using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_from_3: given_a_string_calculator_conext
    {
        Because of =
            () => Result = StringCalculator.Calculate("3-2");

        It should_return_1 =
            () => Result.ShouldEqual(1);
    }
}