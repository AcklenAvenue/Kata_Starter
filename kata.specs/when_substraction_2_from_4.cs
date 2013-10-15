using Machine.Specifications;

namespace kata.specs
{
    public class when_substraction_2_from_4 : given_calculator_context
    {
        Because of =
            () => _result = _calculator.Calculate("4-2");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}