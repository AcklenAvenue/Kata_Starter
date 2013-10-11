using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_4_from_7 : given_a_string_calculator_context
    {
        static int _result;

        Because of =
            () => _result = Calculator.Calculate("7-4");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}