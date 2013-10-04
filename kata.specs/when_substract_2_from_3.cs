using Machine.Specifications;

namespace kata.specs
{
    public class when_substract_2_from_3 : given_a_string_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _calculator.Calculate("3-2");

        It should_return_1 =
            () => _result.ShouldEqual(1);
    }
}