﻿using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_2_from_4: given_a_string_calculator
    {

        Because of =
            () => _result = _stringCalculator.Calculate("4-2");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}