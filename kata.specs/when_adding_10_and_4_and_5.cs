using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_10_and_4_and_5 :given_calculator_context
    {

        Because of = () => _result = _calculator.Calculate("10+4+5");

        It should_return_the_correct_result = () => _result.ShouldEqual(19);
    }
}