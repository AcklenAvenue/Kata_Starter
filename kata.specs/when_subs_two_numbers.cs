using Machine.Specifications;

namespace kata.specs
{
    public class when_subs_two_numbers :given_a_calculator
    {
        Because of = () => _result = _calculator.Calculate("1-10");

        It should_return_minus_9 = () => _result.ShouldEqual(-9);
    }
}