﻿using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_2_and_substracting_1 : given_a_string_calculator_context
    {
        Because of =
            () => Result = StringCalculator.Calculate("1+2-1");

        It should_return_2 =
            () => Result.ShouldEqual(2);
    }
}