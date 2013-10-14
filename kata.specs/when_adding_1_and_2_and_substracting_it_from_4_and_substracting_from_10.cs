using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_and_2_and_substracting_it_from_4_and_substracting_from_10 : given_a_string_calculator_context
    {
        
        private Because of = () => { Result = StringCalculator.Calculate("10-4-2+1"); };

        It should_return_6 = () => { Result.ShouldEqual(5); };
    }
}