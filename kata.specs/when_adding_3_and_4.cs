using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_3_and_4 : given_a_calculator
    {
        Because of =
            () => _result = _Calculator.Calculate("3+4");

        It should_return_7 =
            () => _result.ShouldEqual(7);
    }
}