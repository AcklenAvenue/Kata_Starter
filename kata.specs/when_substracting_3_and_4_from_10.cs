using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_3_and_4_from_10 : given_a_string_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _calculator.Calculate("10-3-4");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}