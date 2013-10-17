using Machine.Specifications;

namespace kata.specs
{
    public class given_a_string_calcultor_context
    {
        protected static StringCalculator Calculator;
        protected static int Result;
        Establish context = () => { Calculator = new StringCalculator(); };
    }
}