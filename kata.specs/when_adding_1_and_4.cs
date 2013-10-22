using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_and_4:given_a_string_calculator_context
    {
        Because of =
            () => Result = StringCalculator.Calculate("1+4");

        It should_return_5 =
            () => Result.ShouldEqual(5);
    }
}