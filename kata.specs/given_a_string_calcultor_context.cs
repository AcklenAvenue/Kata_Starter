using Machine.Specifications;

namespace kata.specs
{
    public class given_a_string_calcultor_context
    {
        protected static StringCalculator StringCalculator;

        Establish context =
            () => { StringCalculator = new StringCalculator(); };
    }
}