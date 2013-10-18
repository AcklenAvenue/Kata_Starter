using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_and_2_and_substracting_1 :given_a_calculator
    {
        Because of =
            () => _result = _Calculator.Calculate("1+2-1");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}