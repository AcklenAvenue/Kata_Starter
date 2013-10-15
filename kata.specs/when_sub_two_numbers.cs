using Machine.Specifications;

namespace kata.specs
{
    public class when_sub_two_numbers : given_a_string_calculator_context
    {
        
        Because of = () => _result = _calculator.Calculate("100-1");

        It should_return_99 = () => _result.ShouldEqual(99);
    }
}