using Machine.Specifications;

namespace kata.specs
{
    public class when_subs_multiple_numbers :given_context
    {
       
        Because of = () => _result = _calculator.Calculate("3-2-1");

        It should_return = () => _result.ShouldEqual(0);
        static int _result;
    }
}