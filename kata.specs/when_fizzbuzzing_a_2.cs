using Machine.Specifications;

namespace kata.specs
{
    class when_fizzbuzzing_a_2 : given_a_fizzbuzz_context
    {
        static string _result;

        Because of = () => { _result = _fizzbuzzer.GetValue(2); };

        It should_return_2 = () => _result.ShouldEqual("2");
    }
}