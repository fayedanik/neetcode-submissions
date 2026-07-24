/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        var numbers = new List<int>();
        TraverseBST(root,numbers);
        return k > numbers.Count ? -1 : numbers[k-1];
    }

    public void TraverseBST(TreeNode root, List<int> numbers) {
        if(root == null) {
            return;
        }
        TraverseBST(root.left,numbers);
        numbers.Add(root.val);
        TraverseBST(root.right, numbers);
    }
}
