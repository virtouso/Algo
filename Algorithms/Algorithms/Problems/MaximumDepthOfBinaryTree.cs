using System;

namespace Algorithms.Problems
{
    public class MaximumDepthOfBinaryTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int value)
            {
                val = value;
                left = null;
                right = null;
            }
        }

        public int MaxDepth(TreeNode node)
        {
            if (node == null)
                return 0;

            int leftDepth = MaxDepth(node.left);
            int rightDepth = MaxDepth(node.right);

            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}