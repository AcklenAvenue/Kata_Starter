using Machine.Specifications;

namespace kata.specs
{
    public class given_a_string_calculator_context
    {
        protected static StringCalculator StringCalculator;
        protected static int _result;

        Establish context =
            () => { StringCalculator = new StringCalculator(); };
    }
}