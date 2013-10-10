using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_and_subs_multiple_random_numbers : given_a_calculator_context
    {
        Because of = () => _result = _calculator.Calculate("100-50-1+20");

        It should_return_correct_result = () => _result.ShouldEqual(69);
    }
}