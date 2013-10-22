using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_from_5:given_a_string_calculotre_context
    {
        Because of =
            () => Result = Calculator.Calculate("5-2");

        It should_return_3 =
            () => Result.ShouldEqual(3);

        
    }
}