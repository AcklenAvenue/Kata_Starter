using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_3_and_2_and_2:given_a_string_calcultor_context
    {
        Because of =
            () => Result = Calculator.Calculate("3+2+2");

        It should_return_7 =
            () => Result.ShouldEqual(7);
    }
}