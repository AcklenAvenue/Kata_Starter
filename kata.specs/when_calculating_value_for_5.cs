using Machine.Specifications;

namespace kata.specs
{
    public class when_calculating_value_for_5 : given_a_fizzbuzz_controller
    {
        
        Because of = () => _result = _fizzBuzzer.Calculate(5);

        It should_do_something = () => _result.ShouldEqual("Buzz");
        static string _result;
    }
}