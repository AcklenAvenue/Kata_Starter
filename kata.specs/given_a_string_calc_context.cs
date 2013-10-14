using Machine.Specifications;

namespace kata.specs
{
    public class given_a_string_calc_context
    {
        protected static StrinCalc _stringCalc;

        Establish context =
            () => { _stringCalc = new StrinCalc(); };
    }
}