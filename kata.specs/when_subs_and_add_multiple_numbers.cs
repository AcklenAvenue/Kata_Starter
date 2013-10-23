using Machine.Specifications;

namespace kata.specs
{
    public class when_subs_and_add_multiple_numbers: given_a_calculator
    {
        
        Because of = () => _result = _calculator.Calculate("10+20-1");

        It should_return_correct_result = () => _result.ShouldEqual(29);
    }
}