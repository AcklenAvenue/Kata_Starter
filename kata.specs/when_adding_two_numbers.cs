using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_two_numbers : given_a_calculator_context
    {
        Because of = () => _result = _calculator.Calculate("2+2");

        It should_return_a_correct_result = () => _result.ShouldEqual(4);
    }
}