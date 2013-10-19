using Machine.Specifications;

namespace kata.specs
{
    public class given_calculator_context
    {
        static StringCalculator _calculator;
        static int _result;

        Establish context =
            () => { _calculator = new StringCalculator(); };
    }
}