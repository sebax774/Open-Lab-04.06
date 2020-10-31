using NUnitLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            var retl = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] % 2 == 0)
                    retl.Add(numbers[i]);
            int[] reta = retl.ToArray();
            return reta;
        }
    }
}
