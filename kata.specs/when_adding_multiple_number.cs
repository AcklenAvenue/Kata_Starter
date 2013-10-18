using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_multiple_number : given_calculator_context
    {
        Because of = () => _result = _calculator.Calculate("1+1+10");

        It should_return_correct_result = () => _result.ShouldEqual(12);
    }
}