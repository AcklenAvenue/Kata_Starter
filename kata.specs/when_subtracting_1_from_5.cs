using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_1_from_5 :given_a_calculator
    {
        Because of =
            () => _result = _Calculator.Calculate("5-1");

        It should_return_4 =
            () => _result.ShouldEqual(4);
    }
}