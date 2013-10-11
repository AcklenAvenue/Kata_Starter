using Machine.Specifications;

namespace kata.specs
{
    class when_subtracting_20_10_and_4 : given_a_string_calculator_context
    {
        static int _result;
        Because of = () => { _result = Calculator.Calculate("20-10-4"); };

        It should_return_6 = () => _result.ShouldEqual(6);
    }
}