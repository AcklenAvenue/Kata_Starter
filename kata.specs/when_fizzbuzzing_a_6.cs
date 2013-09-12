using Machine.Specifications;

namespace kata.specs
{
    class when_fizzbuzzing_a_6 : given_a_fizzbuzz_context
    {

        Because of = () => { _result = _fizzbuzzer.GetValue(6); };

        It should_return_a_fizz = () => _result.ShouldEqual("fizz");
        static string _result;
    }
}