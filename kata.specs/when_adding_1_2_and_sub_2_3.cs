using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_2_and_sub_2_3 : given_context
    {
        Because of =
            () => _result = _stringCalculator.Calculate("1+2+2-3");

        It should_return_2 =
            () => _result.ShouldEqual(2);

        static int _result;
    }
}