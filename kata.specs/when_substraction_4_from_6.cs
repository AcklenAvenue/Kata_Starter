using Machine.Specifications;

namespace kata.specs
{
    public class when_substraction_4_from_6 : given_calculator_context
    {

        Because of =
            () => _result = _stringCalculator.Calculate("6-4");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}