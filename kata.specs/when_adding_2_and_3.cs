using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_3 : given_a_string_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _calculator.Calculate("2+3");

        It should_return_5 =
            () => _result.ShouldEqual(5);
    }
}