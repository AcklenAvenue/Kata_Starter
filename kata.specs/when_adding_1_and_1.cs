using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_and_1
    {
        Establish context =
            () => { _stringCalculator= new StringCalculator(); };

        Because of =
            () => _result = _stringCalculator.Calculate("1+1");

        It should_return_2 =
            () => _result.ShouldEqual(2);

        static int _result;
        static StringCalculator _stringCalculator;
    }
}