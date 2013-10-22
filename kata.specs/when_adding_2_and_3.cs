using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_3 : given_a_string_calculotre_context
    {
        Because of =
            () => Result = Calculator.Calculate("2+3");

        It should_do_something =
            () => Result.ShouldEqual(5);
    }
}