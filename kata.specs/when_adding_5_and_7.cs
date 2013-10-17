using Machine.Specifications;
using kata;

class when_adding_5_and_7
{
    static StringCalculator _calculator;
    static int _result;
    Establish context = () => { _calculator = new StringCalculator(); };

    Because of = () => { _result = _calculator.Calculate("5+7"); };

    It should_return_12 = () => _result.ShouldEqual(12);
}