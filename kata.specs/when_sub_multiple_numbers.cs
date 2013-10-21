using Machine.Specifications;

namespace kata.specs
{
    public class when_sub_multiple_numbers: given_a_calculator
    {
        
        Because of = () => _result = _calculator.Calculate("11-1-1");

        It should_return_correct_result = () => _result.ShouldEqual(9);
    }
}