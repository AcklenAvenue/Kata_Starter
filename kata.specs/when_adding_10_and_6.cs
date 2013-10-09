using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_10_and_6
    {
        static StringCalculator _stringCalculator;
        static int _result;

        Establish context =
            () => { _stringCalculator = new StringCalculator(); };

        Because of =
            () => _result = _stringCalculator.Calculate("10+6");

        It should_return_16 =
            () => _result.ShouldEqual(16);
    }
}