using Machine.Specifications;

namespace kata.specs
{
    public class when_sub_and_add_at_the_same_time : given_string_calculator_context
    {


        Because of =
            () => Result = Calculator.Calculate("50-30+5");

        It should_return_25 =
            () => Result.ShouldEqual(25);
    }
}