using System.Collections.Generic;
using Machine.Specifications;

namespace kata.specs
{
    public class when_calculating_for_a_list_of_numbers_with_3_and_5_and_factors_of_3_and_5 : given_a_fizzbuzz_controller
    {
        
        Because of = () => _result = _fizzBuzzer.Calculate(new List<int>(){1,2,3,4,5,6,7,8,9,10});

        It should_return_the_expected_string = () => _result.ShouldEqual("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz");
        static string _result;
    }
}