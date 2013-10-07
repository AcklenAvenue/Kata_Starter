using Machine.Specifications;

namespace kata.specs
{
    public class when_sum_and_subtracting_2_3_5_2: given_a_string_calculator_context
    {
        Because of =
            () => _result = StringCalculator.Calculate("2+3+5-2");

        It should_return_8 =
            () => _result.ShouldEqual(8);
    }
}