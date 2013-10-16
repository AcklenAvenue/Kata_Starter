using Machine.Specifications;

namespace kata.specs
{
    public class when_subs_2_numbers: given_context
    {
        
        Because of = () => _result = _calculator.Calculate("1-2");

        It should_return_1 = () =>_result.ShouldEqual(-1);
        static int _result;
    }
}