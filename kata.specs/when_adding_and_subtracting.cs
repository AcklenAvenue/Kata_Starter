using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_and_subtracting :given_a_string_calculator
    {
        Because of =
            () => Result = StringCalculator.Calculate("2+3-1");

        It should_return_4 =
            () => Result.ShouldEqual(4);
    }
}