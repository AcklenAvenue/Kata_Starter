using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_4_and_5 : given_a_string_calculator_context
    {
        private Because of = () => { Result = StringCalculator.Calculate("4+5"); };

        It should_should = () => Result.ShouldEqual(9);
    }
}