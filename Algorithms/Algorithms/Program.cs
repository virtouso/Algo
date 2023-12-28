using System;
using Algorithms.Problems;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            ValidPalindrome p = new ValidPalindrome();
            
            Console.WriteLine(p.IsPalindrome("A man, a plan, a canal: Panama"));

        }
    }
}