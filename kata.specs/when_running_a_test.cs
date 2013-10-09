using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_4
    {
        Establish context =
            () => { _stringCalculator = new StringCalculator(); };

        Because of =
            () => _result = _stringCalculator.Calculate("2+4");

        It should_return_6 =
            () => _result.ShouldEqual(6);

        static StringCalculator _stringCalculator;
        static int _result;
    }
}