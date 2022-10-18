using System;

public class D_06_02_102._Binary_Tree_Level_Order_Traversal
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {

        Queue<TreeNode> queue = new Queue<TreeNode>();
        var results = new List<IList<int>>();
        if (root == null) return results;
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var result = new List<int>();

            var levelSize = queue.Count;
            for (int i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                result.Add(node.val);
                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            results.Add(result);
        }

        return results;
    }
}

/*
 102. Binary Tree Level Order Traversal

Input: root = [3,9,20,null,null,15,7]
Output: [[3],[9,20],[15,7]]
Example 2:

Input: root = [1]
Output: [[1]]
Example 3:

Input: root = []
Output: []
 */