using Machine.Specifications;

namespace kata.specs
{
    public class given_a_calc_context
    {
        protected static StringCalculator _calculator;
        Establish context = () => { _calculator = new StringCalculator(); };
    }
}