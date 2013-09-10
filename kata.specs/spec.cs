using Machine.Specifications;

namespace kata.specs
{
    public class when_calculating_value_for_3
    {
        Establish context =
            () =>
                {
                    _fizzBuzzer = new FizzBuzzer();
                };

        Because of =
            () => _result = _fizzBuzzer.Calculate(3);

        It should_do_something =
            () => _result.ShouldEqual("Fizz");

        static FizzBuzzer _fizzBuzzer;
        static string _result;
    }
}
