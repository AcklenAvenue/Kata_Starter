using Machine.Specifications;

namespace kata.specs
{
    class when_adding_3_and_7 : given_calculator_context
    {
        Because of = () => { _result = _calculator.Calculate("7+3"); };

        It should_return_10 = () => _result.ShouldEqual(10);
    }
}