using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_and_3:given_a_string_calculator_conext
    {
        Because of =
            () => Result = StringCalculator.Calculate("1+3");

        It should_return_4 =
            () => Result.ShouldEqual(4);
    }
}