using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_and_subtracting_multiple_numbers : given_a_string_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _calculator.Calculate("10+20-5+4-1");

        It should_return_the_sum =
            () => _result.ShouldEqual(28);
    }
}