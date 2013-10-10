using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_10_from_50 : given_a_string_calculator_context
    {


        Because of = () => { Result = StringCalculator.Calculate("50-10"); };

        It should_return_40 = () => Result.ShouldEqual(40);
    }
}