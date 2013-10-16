﻿using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_7_from_14:given_a_string_calculator_context
    {
        Because of =
            () => Result = Calculator.Calculate("14-7");

        It should_return_7 =
            () => Result.ShouldEqual(7);
    }
    public class when_adding_2_and_3_and_4 : given_a_string_calculator_context
    {
        Because of =
            () => Result = Calculator.Calculate("2+3+4");

        It should_return_9 =
            () => Result.ShouldEqual(9);
    }
}