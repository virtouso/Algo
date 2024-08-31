using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class ConstructBinaryTreeFromPreorderAndInorderTraversal
    {
        // preorder = [3, 9, 20, 15, 7]
        // inorder = [9, 3, 15, 20, 7]
        // Output:
        //
        // The binary tree is:
        //   
        // 3
        // / \
        // 9  20
        // /  \
        // 15   7  

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

            private Dictionary<int, int> inorderIndexMap;
            private int preorderIndex;

            public TreeNode BuildTree(int[] preorder, int[] inorder)
            {
                inorderIndexMap = new Dictionary<int, int>();
                preorderIndex = 0;

                // Build a map to get index of root in inorder array quickly
                for (int i = 0; i < inorder.Length; i++)
                {
                    inorderIndexMap[inorder[i]] = i;
                }

                return BuildSubTree(preorder, 0, inorder.Length - 1);
            }

            private TreeNode BuildSubTree(int[] preorder, int left, int right)
            {
                // If there are no elements to construct the tree
                if (left > right)
                {
                    return null;
                }

                // Select the preorderIndex element as the root and increment it
                int rootValue = preorder[preorderIndex++];
                TreeNode root = new TreeNode(rootValue);

                // Build left and right subtree
                // Exclude inorderIndexMap[rootValue] element because it's the root
                root.left = BuildSubTree(preorder, left, inorderIndexMap[rootValue] - 1);
                root.right = BuildSubTree(preorder, inorderIndexMap[rootValue] + 1, right);

                return root;
            }



        }
    }
}