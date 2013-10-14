using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_3_from_10 : given_a_string_calculator_context
    {

        Because of = () => { Result = StringCalculator.Calculate("10-3"); };

        It should_return_7 = () => Result.ShouldEqual(7);
    }
}