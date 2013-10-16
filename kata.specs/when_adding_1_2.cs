using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_2 : given_a_string_calculator_context
    {
        Because of =
            () => Result = StringCalculator.Calculate("1+2");

        It should_return_3 =
            () => Result.ShouldEqual(3);

        
    }
}