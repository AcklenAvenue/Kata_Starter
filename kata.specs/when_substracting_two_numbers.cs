using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_two_numbers :given_a_calculator_context
    {
        Because of = () => _result = _calculator.Calculate("100-1");

        It should_return_the_correct_result = () => _result.ShouldEqual(99);
    }
}