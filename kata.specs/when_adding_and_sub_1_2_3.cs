using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_and_sub_1_2_3 :given_calculator_context

    {

        Because of = () => _result = _calculator.Calculate("1-2+3");

        It should_return_the_correct_result = () => _result.ShouldEqual(2);
    }
}