using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_10_and_6 : given_a_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("10+6");

        It should_return_16 =
            () => _result.ShouldEqual(16);
    }

    class when_adding_5_and_4 : given_a_calculator_context
    {

        static int _result;
        Because of = () => _result = _stringCalculator.Calculate("5+4");

        It should_return_9 = () => _result.ShouldEqual(9);
    }
}