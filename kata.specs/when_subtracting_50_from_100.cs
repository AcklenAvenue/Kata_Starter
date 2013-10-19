﻿using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_50_from_100 : given_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _calculator.Calculate("100-50");

        It should_return_50 =
            () => _result.ShouldEqual(50);
    }
}