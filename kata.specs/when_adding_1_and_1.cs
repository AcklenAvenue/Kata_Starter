using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_and_1 : given_a_string_calculator
    {
        Because of =
            () => Result = StringCalculator.Calculate("1+1");

        It should_return_2 =
            () => Result.ShouldEqual(2);
    }
}