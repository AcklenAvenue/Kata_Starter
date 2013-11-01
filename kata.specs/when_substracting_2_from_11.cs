using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_2_from_11: given_a_context
    {
        Because of =
            () => _result = _calculator.Calculate("11-2");

        It should_return_9 =
            () => _result.ShouldEqual(9);
    }
}