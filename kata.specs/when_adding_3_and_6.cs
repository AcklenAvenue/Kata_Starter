using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_3_and_6
    {
        Establish context = () =>
            {
                _calculator = new StringCalculator();
            };

        Because of = () => { _result = _calculator.Calculate("3+6"); };

        It should_return_9 = () => _result.ShouldEqual(9);
        static StringCalculator _calculator;
        static int _result;
    }
}