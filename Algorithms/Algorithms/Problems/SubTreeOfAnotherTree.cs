namespace Algorithms.Problems
{
    public class SubTreeOfAnotherTree
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


        public bool IsSubtree(TreeNode s, TreeNode t) {
            if (s == null)
                return false;
            if (IsSameTree(s, t))
                return true;
            return IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }
    
        private bool IsSameTree(TreeNode s, TreeNode t) {
            if (s == null && t == null)
                return true;
            if (s == null || t == null)
                return false;
            return s.val == t.val && IsSameTree(s.left, t.left) && IsSameTree(s.right, t.right);
        }
    }
}