using Machine.Specifications;

namespace kata.specs
{
    class when_subtracting_5_from_10 : given_a_string_calculator_context
    {
        static int _result;
        Because of = () => { _result = Calculator.Calculate("10-5"); };

        It should_return_5 = () => _result.ShouldEqual(5);
    }
}