using Machine.Specifications;
using kata.specs;

class when_subtracting_2_from_4 : given_calculator_context
{

    Because of = () => { _result = _calculator.Calculate("4-2"); };

    It should_return_2 = () => _result.ShouldEqual(2);
}

public class when_subs_multiple_numbers: given_calculator_context
{
    Because of = () => _result = _calculator.Calculate("4-2-1");

    It should_return_correct_result = () => _result.ShouldEqual(1);
}