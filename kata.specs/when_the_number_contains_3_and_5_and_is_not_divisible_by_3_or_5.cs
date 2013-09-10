using Machine.Specifications;

namespace kata.specs
{
    public class when_the_number_contains_3_and_5_and_is_not_divisible_by_3_or_5 : given_a_fizz_buzzer_context
    {

        static string _result;

        Establish context =
            () => {  };

        Because of =
            () => _result = FizzBuzzer.Play(352);

        It should_return_fizzbuzz =
            () => { _result.ShouldEqual("fizzbuzz"); };
    }


}