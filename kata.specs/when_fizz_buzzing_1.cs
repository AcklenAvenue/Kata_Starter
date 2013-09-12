using Machine.Specifications;

namespace kata.specs
{
    public class when_fizz_buzzing_1
    {
        static FizzBuzzer _fizzbuzzer;
        static string _result;

        Establish context =
            () => { _fizzbuzzer = new FizzBuzzer(); };

        Because of =
            () => _result = _fizzbuzzer.GetValue(1);

        It should_return_1 =
            () => _result.ShouldEqual("1");
    }
}