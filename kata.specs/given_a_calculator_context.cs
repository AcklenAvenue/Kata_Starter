using Machine.Specifications;

namespace kata.specs
{
    public class given_a_calculator_context
    {
        Establish context = () => { _calculator = new StringCalculator(); };
        protected static StringCalculator _calculator;
    }
}