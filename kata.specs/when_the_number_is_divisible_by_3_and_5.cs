using Machine.Specifications;

namespace kata.specs
{
    public class when_the_number_is_divisible_by_3_and_5 : given_a_fizz_buzzer_context
    {
        Because of =
            () => _result = FizzBuzzer.Play(15);

        It should_return_the_word_fizzbuzz =
            () => _result.ShouldEqual("fizzbuzz");

        static string _result;
    }
}