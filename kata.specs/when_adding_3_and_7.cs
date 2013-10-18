using Machine.Specifications;
using kata.specs;

namespace kata.specs
{
    class when_adding_3_and_7 : given_calculator_context
    {
        Because of = () => { _result = _calculator.Calculate("7+3"); };

        It should_return_10 = () => _result.ShouldEqual(10);
    }
}

class when_subtracting_2_from_4 : given_calculator_context
{

    Because of = () => { _result = _calculator.Calculate("4-2"); };

    It should_return_2 = () => _result.ShouldEqual(4);
}