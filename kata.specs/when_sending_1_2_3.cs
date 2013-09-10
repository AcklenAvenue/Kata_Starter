using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_1_2_3 : given_a_fizzbuzz_context
    {
        static string _result;

        Because of =
            () => _result = _fizzBuzz.Send("1_2_3");

        It should_return_1_2_Fizz =
            () => _result.ShouldEqual("1 2 Fizz");
    }
}