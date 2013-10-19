using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_200_from_500 : given_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _calculator.Calculate("500-200");

        It should_return_300 =
            () => _result.ShouldEqual(300);
    }
}