﻿using Machine.Specifications;

namespace kata.specs
{
    public class when_sub_1_from_3 : given_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("3-1");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}