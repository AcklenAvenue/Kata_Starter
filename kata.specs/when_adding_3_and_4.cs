using Machine.Specifications;

namespace kata.specs
{
    class when_adding_3_and_4
    {
        Establish context = () =>
            {
                _calculator = new StringCalculator();
            };

        Because of = () => { _result = _calculator.Calculate("3+4"); };

        It should_return_7 = () => _result.ShouldEqual(7);
        static StringCalculator _calculator;
        static int _result;
    }
}