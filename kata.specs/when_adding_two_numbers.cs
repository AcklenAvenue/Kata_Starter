using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_two_numbers : given_a_calculator
    {
        Because of = () => _result = _calculator.Calculate("2+1");

        It should_return_correct_result = () => _result.ShouldEqual(3);
    }
}