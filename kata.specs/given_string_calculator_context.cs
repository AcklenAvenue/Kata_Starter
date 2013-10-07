using Machine.Specifications;

namespace kata.specs
{
    public class given_string_calculator_context
    {
        protected static StringCalculator StringCalculator;

        Establish context =
            () => { StringCalculator = new StringCalculator(); };
    }
}