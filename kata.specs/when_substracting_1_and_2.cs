using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_1_from_2 : given_a_string_calculator_context
    {
        private Because of = () => Result = StringCalculator.Calculate("2-1");

        It should_return_1 = () => Result.ShouldEqual(1);
    }
}