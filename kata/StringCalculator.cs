using System;
using System.Linq;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var nums = s.Split('+');
            var totalGlobal = 0;
            foreach (var num in nums)
            {
                if (num.Contains("-"))
                {
                    var Nums = num.Split('-');
                    var total = Convert.ToInt32(Nums.First());
                    for (int i = 1; i < Nums.Length; i++)
                    {
                        total -= Convert.ToInt32(Nums[i]);
                    }
                    totalGlobal += total;
                }
                else
                {
                    totalGlobal += Convert.ToInt32(num);
                }
            }

            return totalGlobal;
        }
    }
}