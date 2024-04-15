using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Algorithms.Problems
{
    public class GreatestCommonDivisor
    {
        static int Gcd(int a, int b)
        {
           
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

         int GcdList(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("List cannot be null or empty.");
            }

            int gcd = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                gcd = Gcd(gcd, numbers[i]);
            }

            return gcd;
        }
        
        public void Run()
        {
            Assert.That(Gcd(24,36)==12);
        }
        
    }
}