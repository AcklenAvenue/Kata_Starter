using Machine.Specifications;

namespace kata.specs
{
    public class when_substraction_2_from_4 : given_context_string_calculator
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("4-2");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}