using Machine.Specifications;
using kata.specs;

public class when_subs_multiple_numbers: given_calculator_context
{
    Because of = () => _result = _calculator.Calculate("4-2-1");

    It should_return_correct_result = () => _result.ShouldEqual(1);
}