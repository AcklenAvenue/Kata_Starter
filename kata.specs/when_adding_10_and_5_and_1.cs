using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_10_and_5_and_1 : given_a_calc
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("10+5+1");

        It should_return_16 =
            () => _result.ShouldEqual(16);
    }
}