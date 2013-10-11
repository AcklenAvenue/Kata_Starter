using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_2 : given_a_string_calculator_context
    {
        static int _result;

        Because of =
            () => _result = Calculator.Calculate("2+2");

        It should_return_4 =
            () => _result.ShouldEqual(4);
    }
}