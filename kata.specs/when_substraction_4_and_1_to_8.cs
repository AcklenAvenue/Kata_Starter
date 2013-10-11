using Machine.Specifications;

namespace kata.specs
{
    public class when_substraction_4_and_1_to_8: given_calculator_context
    {
        Because of =
            () => _result = _stringCalculator.Calculate("8-1-4");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}