using System;
using System.ComponentModel;
using Algorithms.Problems;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CoinChangeProblem coin = new CoinChangeProblem();
            var res = coin.CoinChange(new[] { 1, 2, 5 }, 11);
            Console.WriteLine(res);
        }
    }
}