using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_2_3 : given_context
    {
        Because of =
            () => _result = _stringCalculator.Calculate("1+2+3");

        It should_return_6 =
            () => _result.ShouldEqual(6);

        static int _result;
    }
}