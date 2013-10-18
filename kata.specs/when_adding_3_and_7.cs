using Machine.Specifications;

namespace kata.specs
{
    class when_adding_3_and_7
    {
        Establish context = () =>
            {
                _calculator = new StringCalculator();
            };

        Because of = () => { _result = _calculator.Calculate("7+3"); };

        It should_return_10 = () => { };
        static StringCalculator _calculator;
        static int _result;
    }
}