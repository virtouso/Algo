using System;

namespace Algorithms.Problems
{
    // The Binary Tree Maximum Path Sum problem on LeetCode involves finding the maximum sum of any path in a binary tree.
    // A path is defined as a sequence of nodes where each node is connected to the next node by its parent or child relationship.
    // The path can start and end at any node, but it must be continuous.

    //  Problem Statement:
    //  Given the root of a binary tree, return the maximum path sum.


    public class CalculateMaxPathSumProblem // hard
    {
        private int maxPathSum = int.MinValue;

        public int MaxPathSum(TreeNode root)
        {
            CalculateMaxPathSum(root);
            return maxPathSum;
        }

        private int CalculateMaxPathSum(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            // Recursively get the maximum path sum for left and right subtrees
            int leftMax = Math.Max(CalculateMaxPathSum(node.left), 0); // Only add positive contributions
            int rightMax = Math.Max(CalculateMaxPathSum(node.right), 0); // Only add positive contributions

            // Calculate the maximum path sum with the current node as the highest node
            int currentPathSum = node.val + leftMax + rightMax;

            // Update the global maximum path sum
            maxPathSum = Math.Max(maxPathSum, currentPathSum);

            // Return the maximum path sum for the current node, which is the node's value plus the maximum of its left or right path sum
            return node.val + Math.Max(leftMax, rightMax);
        }
    }

// Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}