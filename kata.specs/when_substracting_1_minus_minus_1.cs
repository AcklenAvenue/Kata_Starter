using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_1_minus_minus_1 :given_a_calculator
    {
        Because of =
            () => _result = _Calculator.Calculate("1-(-1)");

        It should_retuns_minus_2 =
            () => _result.ShouldEqual(-2);
    }
}