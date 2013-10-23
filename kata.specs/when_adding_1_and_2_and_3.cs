using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_and_2_and_3 : given_a_calculator
    {
        Because of =
            () => _result = _calculator.Calculate("1+2+3");

        It should_return_6 =
            () => _result.ShouldEqual(6);
    }
}