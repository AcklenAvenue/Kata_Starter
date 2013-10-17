using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_1_and_2_from_10:given_a_string_calcultor_context  
    {
        Because of =
            () => Result = Calculator.Calculate("10-2-1");

        It should_return_7 =
            () => Result.ShouldEqual(7);
    }
}