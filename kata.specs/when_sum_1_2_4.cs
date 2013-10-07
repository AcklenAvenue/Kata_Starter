using Machine.Specifications;

namespace kata.specs
{
    public class when_sum_1_2_4: given_a_string_calculator_context
    {
        Because of =
            () => _result = StringCalculator.Calculate("1+2+4");

        It should_return_7 =
            () => _result.ShouldEqual(7);
    }
}