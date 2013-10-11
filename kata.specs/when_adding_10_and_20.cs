using Machine.Specifications;

namespace kata.specs
{
    class when_adding_10_and_20
    {
        Establish context = () =>
            {
                _calculator = new StringCalculator();
            };

        Because of = () => { _result = _calculator.Calculate("10+20"); };

        It should_return_30 = () => _result.ShouldEqual(30);
        static StringCalculator _calculator;
        static int _result;
    }
}