using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_5_from_7 : given_a_calc
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("7-5");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}