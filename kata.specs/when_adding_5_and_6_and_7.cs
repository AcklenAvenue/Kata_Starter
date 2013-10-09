using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_5_and_6_and_7 : given_a_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("5+6+7");

        It should_return_18 =
            () => _result.ShouldEqual(18);
    }
}