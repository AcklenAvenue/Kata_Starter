using Machine.Specifications;

namespace kata.specs
{
    public class when_subs_1_and_2_from_5 :given_calculator_context
    {
        Because of =
            () => _result = _calculator.Calculate("5-2-1");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}