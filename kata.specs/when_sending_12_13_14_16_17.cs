using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_12_13_14_16_17: given_a_fizzbuzz_context
    {
        Because of =
            () => _result = _fizzBuzz.Send("12_13_14_16_17");

        It should_return_Fizz_Fizz_14_16_17 = 
            () => _result.ShouldEqual("Fizz Fizz 14 16 17");
    }
}