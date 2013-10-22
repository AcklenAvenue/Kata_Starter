using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_3_from_4_and_adding_2 : given_a_string_calculotre_context
    {
        Because of =
            () => Result = Calculator.Calculate("4-3+2");

        It should_return_3 =
            () => Result.ShouldEqual(3);
    }
}