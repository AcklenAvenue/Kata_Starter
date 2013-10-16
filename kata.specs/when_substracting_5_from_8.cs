using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_5_from_8 : given_a_string_calculator_context
    {

        Because of = () => { Result = StringCalculator.Calculate("8-5"); };

        It should_return_3 = () => { Result.ShouldEqual(3); };
    }
}