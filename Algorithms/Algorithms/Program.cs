using System;
using System.ComponentModel;
using Algorithms.Problems;
using NUnit.Framework;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            NumRollsToTargetProblem prob = new NumRollsToTargetProblem();
            prob.NumRollsToTarget(1, 6, 3);
        }
    }
}