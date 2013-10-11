using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_and_adding_10_2_3 : given_a_string_calculator_context
    {
        static int _result;

        Because of =
            () => _result = Calculator.Calculate("10-2+3");

        It should_return_11 =
            () => _result.ShouldEqual(11);
    }
}