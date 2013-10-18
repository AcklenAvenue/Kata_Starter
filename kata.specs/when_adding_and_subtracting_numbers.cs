using Machine.Specifications;
using kata.specs;

class when_adding_and_subtracting_numbers : given_calculator_context
{
    Because of = () => { _result = _calculator.Calculate("15+5-10"); };

    It should_return_10 = () => _result.ShouldEqual(10);
}