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
            ClimbingStairs climb = new ClimbingStairs();
             Assert.That(climb.ClimbStairsWithDecisionTree(0)==0);
             Assert.That(climb.ClimbStairsWithDecisionTree(1)==1);
             Assert.That(climb.ClimbStairsWithDecisionTree(2)==2);
             Assert.That(climb.ClimbStairsWithDecisionTree(3)==3);
             Assert.That(climb.ClimbStairsWithDecisionTree(4)==5);
             Assert.That(climb.ClimbStairsWithDecisionTree(5)==8);
             Assert.That(climb.ClimbStairsWithDecisionTree(6)==13);
        }
    }
}