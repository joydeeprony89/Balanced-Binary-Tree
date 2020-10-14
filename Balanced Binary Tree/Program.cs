using System;
using System.Runtime.CompilerServices;

namespace Balanced_Binary_Tree
{
    class Program
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
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            Console.WriteLine(IsBalanced(root));
        }

        static bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;

            return Helper(root) != -1;
        }

        static int Helper(TreeNode root)
        {
            if (root == null) return 0;

            int left = Helper(root.left);
            int right = Helper(root.right);

            if (left == -1 || right == -1 || Math.Abs(left - right) > 1) return -1;

            return Math.Max(left, right) + 1;
        }
    }
}
