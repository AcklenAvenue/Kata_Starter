using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_3_and_4 : given_a_string_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _calculator.Calculate("2+3+4");

        It should_return_9 =
            () => _result.ShouldEqual(9);
    }
}