using System.ComponentModel;

namespace Algorithms.Problems
{
    public class ValidateBinarySearchTree
    {
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


        private bool result = true;

        public bool IsValidBST(TreeNode root)
        {
            result = true;
            InOrder(root, null, false);

            return result;
        }


        private void InOrder(TreeNode node, TreeNode parent, bool isLeft)
        {
            if (node == null) return;
            if (result == false) return;
            InOrder(node.left, node, true);

            if (parent != null)
            {
                if (isLeft && parent.val < node.val) result = false;
                if (!isLeft && parent.val > node.val) result = false;
            }


            InOrder(node.right, node, false);
        }


        public void Run()
        {
            TreeNode root = new TreeNode { val = 3 };
            TreeNode l1 = new TreeNode { val = 1 };
            TreeNode l2 = new TreeNode { val = 4 };
            root.left = l1;
            root.right = l2;
            TreeNode l3 = new TreeNode { val = 0 };
            l1.right = l3;

            IsValidBST(root);
        }
    }
}