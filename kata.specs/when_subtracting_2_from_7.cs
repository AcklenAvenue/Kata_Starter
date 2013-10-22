using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_from_7:given_a_string_calculotre_context
    {
        Because of =
            () => Result = Calculator.Calculate("7-2");

        It should_5 =
            () => Result.ShouldEqual(5);
    }
}