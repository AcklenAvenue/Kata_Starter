using Machine.Specifications;

namespace kata.specs
{
    public class given_a_string_calculator_context
    {
        protected static StringCalculator Calculator;
        protected static int Result;

        Establish context =
            () => { Calculator = new StringCalculator(); };
    }
}