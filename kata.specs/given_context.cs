using Machine.Specifications;

namespace kata.specs
{
    public class given_context
    {
        Establish context =
            () => { _strincCal = new StringCal(); };

        protected static StringCal _strincCal;
    }
}