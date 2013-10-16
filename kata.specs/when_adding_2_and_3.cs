using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_3
    {
        Establish context =
            () => { _calculator = new StringCalculator(); };

        Because of =
            () => _result = _calculator.Calculate("2+3");

        It should_return_5 =
            () => _result.ShouldEqual(5);

        static StringCalculator _calculator;
        static int _result;
    }
}