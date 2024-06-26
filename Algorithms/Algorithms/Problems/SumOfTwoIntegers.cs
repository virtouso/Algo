﻿namespace Algorithms.Problems
{
    public class SumOfTwoIntegers
    {
        public int GetSum(int a, int b) {
            while (b != 0) {
                int carry = a & b;
                a = a ^ b;
                b = carry << 1;
            }
            return a;
        }
    }
}