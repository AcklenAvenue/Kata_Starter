using Machine.Specifications;

namespace kata.specs
{
    public class when_subtraction_2_and_1_from_5 :given_context_string_calculator
    {
        Because of =
            () => _result = _stringCalculator.Calculate("5-2-1");

        It should_return_2 =
            () => _result.ShouldEqual(2);

        static int _result;
    }
}