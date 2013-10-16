using Machine.Specifications;
using kata.specs;

namespace kata.specs
{
    public class given_context
    {
        protected static StringCalculator _calculator;
        Establish context = () => { _calculator = new StringCalculator(); };
    }
}