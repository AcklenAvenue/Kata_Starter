using System.Collections.Generic;
using Machine.Specifications;

namespace kata.specs
{
    public class when_calculating_value_for_15 : given_a_fizzbuzz_controller
    {
        Because of =
            () => _result = _fizzBuzzer.Calculate(new List<int>(){15});

        It should_do_something =
            () => _result.ShouldEqual("FizzBuzz");

        static string _result;
    }
}