﻿using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_and_2 : given_an_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("1+2");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}