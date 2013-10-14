using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_3_and_4:given_a_string_calculator
    {
        Because of =
            () => Result = StringCalculator.Calculate("2+3+4");
        It should_return_9 =
            () => Result.ShouldEqual(9);
    }
}