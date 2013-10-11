using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_5_and_101 : given_a_calc
    {
        static int _result;

        Because of = () => _result = _stringCalculator.Calculate("5+101");

        It should_return_106 = () => _result.ShouldEqual(106);
    }
}