using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_and_2
    {
        static StringCalculator _calculator;
        static object _result;

        Establish context =
            () => { _calculator = new StringCalculator(); };

        Because of =
            () => _result = _calculator.Calculate("1+2");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}