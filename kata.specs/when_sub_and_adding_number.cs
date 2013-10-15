using Machine.Specifications;

namespace kata.specs
{
    public class when_sub_and_adding_number :given_a_string_calculator_context
    {
        
        Because of = () => _result = _calculator.Calculate("-1-1-1+100");

        It should_return_correct_result = () => _result.ShouldEqual(97);
    }
}