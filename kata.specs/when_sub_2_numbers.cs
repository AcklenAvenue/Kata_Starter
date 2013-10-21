using Machine.Specifications;

namespace kata.specs
{
    public class when_sub_2_numbers: given_a_calculator
    {
        Because of = () => _result = _calculator.Calculate("1-4");

        It should_return_correct_result = () => _result.ShouldEqual(-3);
    }
}