using System;

public class D_08_01_98_Validate_Binary_Search_Tree
{
    public bool IsValidBST(TreeNode root)
    {
        return isBSTUtil(root, long.MinValue, long.MaxValue);
    }

    public virtual bool isBSTUtil(TreeNode node, long min, long max)
    {

        if (node == null)
        {
            return true;
        }


        if (node.val <= min || node.val >= max)
        {
            return false;
        }

        return (
                isBSTUtil(node.left, min, node.val)
            && isBSTUtil(node.right, node.val, max));
    }

}

/*
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

public class BinaryTree
{

    public TreeNode root;


    public bool IsValidBST
    {

        get { 
            return isBSTUtil(root, long.MinValue, long.MaxValue);
        }
    }

        
    public virtual bool isBSTUtil(TreeNode node, long min,
                            long max)
    {
            
        if (node == null)
        {
            return true;
        }


        if (node.val <= min || node.val >= max)
        {
            return false;
        }


        return (
            isBSTUtil(node.left, min, node.val)
            && isBSTUtil(node.right, node.val, max));
    }

        
    public static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();
        tree.root = new TreeNode(4);
        tree.root.left = new TreeNode(2);
        tree.root.right = new TreeNode(5);
        tree.root.left.left = new TreeNode(1);
        tree.root.left.right = new TreeNode(3);

        // Function call
        if (tree.IsValidBST)
        {
            Console.WriteLine("IS BST");
        }
        else
        {
            Console.WriteLine("Not a BST");
        }
    }
}
 */

/*
 98. Validate Binary Search Tree

Given the root of a binary tree, determine if it is a valid binary search tree (BST).

A valid BST is defined as follows:

The left subtree of a node contains only nodes with keys less than the node's key.
The right subtree of a node contains only nodes with keys greater than the node's key.
Both the left and right subtrees must also be binary search trees.
 

Example 1:


Input: root = [2,1,3]
Output: true
Example 2:


Input: root = [5,1,4,null,null,3,6]
Output: false
Explanation: The root node's value is 5 but its right child's value is 4.
 */
