﻿using Machine.Specifications;

namespace kata.specs
{
    public class given_calculator_context
    {
        Establish context =
            () => { _stringCalculator = new StringCalculator(); };

        protected static StringCalculator _stringCalculator;
        protected static int _result;
    }
}