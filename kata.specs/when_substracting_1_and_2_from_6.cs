using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_1_and_2_from_6 : given_a_calculator
    {
        Because of =
            () => _result = _Calculator.Calculate("6-2-1");

        It should_return_3=
            () => _result.ShouldEqual(3);
    }
}