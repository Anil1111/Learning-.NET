﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    static class SqrtPrecalculated
    {
        public const int MaxValue = 1000;

        // Static field
        private static int[] sqrtValues;

        // Static constructor
        static SqrtPrecalculated()
        {
            sqrtValues = new int[MaxValue + 1];
            for (int i = 0; i < sqrtValues.Length; i++)
            {
                sqrtValues[i] = (int)Math.Sqrt(i);
            }
        }

        // Static method
        public static int GetSqrt(int value)
        {
            if ((value < 0) || (value > MaxValue))
            {
                throw new ArgumentOutOfRangeException(String.Format("The argument should be in range [0....{0}]", MaxValue)); 
            }
            return sqrtValues[value];
        }
    }
}
