using Machine.Specifications;

namespace kata.specs
{
    public class when_sum_1_1: given_a_string_calculator_context
    {
        Because of =
            () => _result = StringCalculator.Calculate("1+1");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}