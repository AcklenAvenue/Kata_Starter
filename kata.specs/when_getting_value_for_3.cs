using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace kata.specs
{
    public class when_getting_value_for_3 :given_a_fizzbuzzer_context
    {
        Because of =
            () => _result = _fizzBuzzer.Calculate(3);

        It should_return_fizz =
            () => _result.ShouldEqual("fizz");
    }
}
