using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_4_from_11 : given_a_string_calculator_context
    {

        Because of =
            () => Result = StringCalculator.Calculate("11-4");

        It should_return_7 =
            () => Result.ShouldEqual(7);
    }
}