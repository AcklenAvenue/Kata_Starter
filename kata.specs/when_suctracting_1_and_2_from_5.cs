using Machine.Specifications;

namespace kata.specs
{
    public class when_suctracting_1_and_2_from_5 : given_a_string_calculator_context
    {
        
        private Because of = () => { Result = StringCalculator.Calculate("5-2-1"); };

        It should_return = () => { Result.ShouldEqual(2); };
    }
}