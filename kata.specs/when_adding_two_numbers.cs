using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_two_numbers : given_a_string_calculator_context
    {
        Because of = () => _result = _calculator.Calculate("1+2");

        It should_return_3 = () => _result.ShouldEqual(3);
    }
}