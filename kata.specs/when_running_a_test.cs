using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_2 : given_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("1+2");

        It should_do_something =
            () => _result.ShouldEqual(3);
    }
}