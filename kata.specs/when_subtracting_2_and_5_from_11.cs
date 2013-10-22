using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_and_5_from_11:given_a_string_calculotre_context
    {
        Because of =
            () => Result = Calculator.Calculate("11-2-5");

        It should_return_4 =
            () => Result.ShouldEqual(4);
    }
}