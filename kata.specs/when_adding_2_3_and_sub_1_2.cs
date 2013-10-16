using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_3_and_sub_1_2 : given_a_string_calculator_context
    {
        Because of =
            () => Result = StringCalculator.Calculate("2+3-1-2");

        It should_return_2 =
            () => Result.ShouldEqual(2);
    }
}