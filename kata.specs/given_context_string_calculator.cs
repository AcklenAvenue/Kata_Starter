using Machine.Specifications;

namespace kata.specs
{
    public class given_context_string_calculator
    {
        protected static StringCalculator _stringCalculator;

        Establish context =
            () => { _stringCalculator = new StringCalculator(); };
    }
}