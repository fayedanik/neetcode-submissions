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
        var st = new Stack<TreeNode>();
        TreeNode current = root;
        int n = 0;
        while(current != null || st.Count > 0) {
            while(current != null) {
                st.Push(current);
                current = current.left;
            }
            current = st.Pop();
            n++;
            if(n == k) return current.val;
            current = current.right;
        }
        
        return -1;
    }
}
