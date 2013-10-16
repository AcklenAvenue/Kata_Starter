using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_5
    {
        static StringCalculator _stringCalculator;
        static int _result;

        Establish context =
            () => { _stringCalculator = new StringCalculator(); };

        Because of =
            () => _result = _stringCalculator.Calculate("2+5");

        It should_return_7 =
            () => _result.ShouldEqual(7);
    }
}