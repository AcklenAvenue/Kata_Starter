using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_two_numbers : given_a_calculator
    {
        Because of = () => _result = _calculator.Calculate("1+1");

        It should_return_result = () => _result.ShouldEqual(2);
    }
}