using Machine.Specifications;

namespace kata.specs
{
    public class when_calculating_value_for_3 : given_a_fizzbuzz_controller
    {
        Because of =
            () => _result = _fizzBuzzer.Calculate(3);

        It should_do_something =
            () => _result.ShouldEqual("Fizz");

        static string _result;
    }
}