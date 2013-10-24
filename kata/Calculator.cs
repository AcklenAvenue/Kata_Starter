using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace kata
{
    public class Calculator
    {
        public int Calculate(string s)
        {
            var numbersSplit = Regex.Split(s, @"([+|-][0-9]+)");
            return numbersSplit.Where(s1 => s1 != "").Sum(s1 => int.Parse(s1));
        }
    }
}