using Machine.Specifications;

namespace kata.specs
{
    public class when_calculating_value_for_1 : given_a_fizzbuzz_controller
    {
        Because of =
            () => _result = _fizzBuzzer.Calculate(1);

        It should_do_something =
            () => _result.ShouldEqual("1");

        static string _result;
    }
}