using Machine.Specifications;

namespace kata.specs
{
    public class when_sub_and_add : given_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _calculator.Calculate("100-50+25");

        It should_return_75 =
            () => _result.ShouldEqual(75);
    }
}