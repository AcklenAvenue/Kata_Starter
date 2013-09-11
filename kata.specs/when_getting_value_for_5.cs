using Machine.Specifications;

namespace kata.specs
{
    public class when_getting_value_for_5
    {
        Establish context =
            () => { _fizzBuzzer = new FizzBuzzer(); };

        Because of =
            () => _result = _fizzBuzzer.Calculate(5);

        It should_do_something =
            () => _result.ShouldEqual("buzz");

        static FizzBuzzer _fizzBuzzer;
        static string _result;
    }
}