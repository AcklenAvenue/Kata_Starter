using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_1_from_4 : given_a_calculator
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("4-1");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}