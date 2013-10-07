using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_4_and_5
    {
        static StringCalculator _stringCalculator;
        static int _result;

        Establish context =
            () => { _stringCalculator = new StringCalculator(); };

        Because of =
            () => _result = _stringCalculator.Calculate("4+5");

        It should_return_9 =
            () => _result.ShouldEqual(9);
    }
}