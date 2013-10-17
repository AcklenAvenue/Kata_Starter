using Machine.Specifications;

namespace kata.specs
{
    public class given_a_context
    {
        Establish context =
            () => { _stringCalculator = new StringCalculator(); };

        protected static StringCalculator _stringCalculator;
    }
}