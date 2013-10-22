using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_4:given_a_string_calculotre_context
    {
        Because of =
            () => Result = Calculator.Calculate("2+4");

        It should_return_6 =
            () => Result.ShouldEqual(6);
    }
}