using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_3_and_subtracting_5 : given_a_context
    {
        Because of =
            () => _result = _calculator.Calculate("2+3-5");

        It should_return_0 =
            () => _result.ShouldEqual(0);
    }
}