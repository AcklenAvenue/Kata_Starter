using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_3_2 : given_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _calculator.Calculate("3+2");

        It should_return_5 =
            () => _result.ShouldEqual(5);
    }
}