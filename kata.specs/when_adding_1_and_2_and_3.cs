using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_and_2_and_3 : given_an_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("1+2+3");

        It should_return_6 =
            () => _result.ShouldEqual(6);
    }
}