using System;

public class D_08_02_235_Lowest_Common_Ancestor_of_a_Binary_Search_Tree
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        while (root != null)
        {

            if (root.val > p.val && root.val > q.val)
                root = root.left;

            else if (root.val < p.val && root.val < q.val)
                root = root.right;

            else
                break;
        }
        return root;
    }
}


/*
using System;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class BinaryTree
{
    public TreeNode root;

    //Function to find LCA of n1 and n2.
    //The function assumes that both
    //p and q are present in BST 
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        while (root != null)
        {
            // If both p and q are smaller than
            // root, then LCA lies in left
            if (root.val > p.val && root.val > q.val)
                root = root.left;

            // If both p and q are greater than
            // root, then LCA lies in right
            else if (root.val < p.val && root.val < q.val)
                root = root.right;

            else
                break;
        }
        return root;
    }


    public static void Main(string[] args)
    {        
        BinaryTree tree = new BinaryTree();
        tree.root = new TreeNode(20);
        tree.root.left = new TreeNode(8);
        tree.root.right = new TreeNode(22);
        tree.root.left.left = new TreeNode(4);
        tree.root.left.right = new TreeNode(12);
        tree.root.left.right.left = new TreeNode(10);
        tree.root.left.right.right = new TreeNode(14);

        
        TreeNode p = new TreeNode(10);
        TreeNode q = new TreeNode(14);

        TreeNode t = tree.LowestCommonAncestor(tree.root, p, q);
        Console.WriteLine("LCA of " + p.val + " and " + q.val
                          + " is " + t.val);

        TreeNode a = new TreeNode(14);
        TreeNode b = new TreeNode(8);

        t = tree.LowestCommonAncestor(tree.root, a, b);
        Console.WriteLine("LCA of " + a.val + " and " + b.val
                          + " is " + t.val);

        a.val = 10;
        b.val = 22;
        t = tree.LowestCommonAncestor(tree.root, a, b);
        Console.WriteLine("LCA of " + a.val + " and " + b.val
                          + " is " + t.val);
    }
}
 */
