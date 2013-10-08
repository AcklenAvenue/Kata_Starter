using Machine.Specifications;

namespace kata.specs
{
    public class given_a_string_calc_context
    {
        protected static StringCalculator _stringCalculator;

        Establish context =
            () => { _stringCalculator = new StringCalculator(); };
    }
}