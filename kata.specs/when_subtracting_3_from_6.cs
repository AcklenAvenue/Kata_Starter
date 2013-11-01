using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_3_from_6 : given_a_context
    {
        Because of =
            () => _result = _calculator.Calculate("6-3");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}