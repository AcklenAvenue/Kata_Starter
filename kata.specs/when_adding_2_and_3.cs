using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_3 : given_a_calculator
    {
        Because of =
            () => _result = _calculator.Calculate("2+3");

        It should_return_5 =
            () => _result.ShouldEqual(5);
    }
}