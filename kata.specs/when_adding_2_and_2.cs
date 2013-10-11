using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_2 : given_a_string_calculator_context
    {
        static int _result;

        Because of =
            () => _result = Calculator.Calculate("2+2");

        It should_return_4 =
            () => _result.ShouldEqual(4);
    }

    class when_subtracting_5_from_10 : given_a_string_calculator_context
    {
        Because of = () => { _result = Calculator.Calculate("10-5"); };

        It should_return_5 = () => _result.ShouldEqual(5);
        static int _result;
    }
}