using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_1_2_from_4 : given_a_context
    {
        Because of =
            () => _result = _calculator.Calculate("4-2-1");

        It should_return_1 =
            () => _result.ShouldEqual(1);
    }
}