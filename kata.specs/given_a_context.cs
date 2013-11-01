using Machine.Specifications;

namespace kata.specs
{
    public class given_a_context
    {
        Establish context =
            () => { _calculator = new Calculator(); };

        protected static Calculator _calculator;
        protected static int _result;
    }
}