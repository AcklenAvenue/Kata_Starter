using Machine.Specifications;

namespace kata.specs
{
    class when_fizzbuzzing_a_4 : given_a_fizzbuzz_context
    {

        Because of = () => { _result = _fizzbuzzer.GetValue(4); };

        It should_return_a_4 = () => _result.ShouldEqual("4");
        static string _result;
    }
}