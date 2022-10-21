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

/*
 235. Lowest Common Ancestor of a Binary Search Tree

Given a binary search tree (BST), find the lowest common ancestor (LCA) node of two given nodes in the BST.

According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both p and q as descendants (where we allow a node to be a descendant of itself).”

 

Example 1:


Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8
Output: 6
Explanation: The LCA of nodes 2 and 8 is 6.
Example 2:


Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 4
Output: 2
Explanation: The LCA of nodes 2 and 4 is 2, since a node can be a descendant of itself according to the LCA definition.
Example 3:

Input: root = [2,1], p = 2, q = 1
Output: 2

*/