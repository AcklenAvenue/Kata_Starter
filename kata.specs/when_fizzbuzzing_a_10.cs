using Machine.Specifications;

namespace kata.specs
{
    public class when_fizzbuzzing_a_10 : given_a_fizzbuzz_context
    {
        static string _result;

        Because of =
            () => _result = _fizzbuzzer.GetValue(10);

        It should_return_a_buzz =
            () => "buzz".ShouldEqual(_result);
    }
}