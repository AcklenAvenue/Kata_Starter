using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_5_and_6 : given_an_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("5+6");

        It should_return_11 =
            () => _result.ShouldEqual(11);
    }
}