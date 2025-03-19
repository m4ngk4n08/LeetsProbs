
public class TreeNode
{
    public int? _val;
    public TreeNode _left;
    public TreeNode _right;

    public TreeNode(int? val, TreeNode left = null, TreeNode right = null)
    {
        _val = val;
        _left = left;
        _right = right;
    }

    #region BuildTree
    public static TreeNode BuildTree(int?[] nums)
    {
        if (nums.Length == 0 || nums[0] == null) return null;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        TreeNode root = new TreeNode(nums[0]);
        queue.Enqueue(root);

        int i = 1;
        while (i < nums.Length)
        {
            TreeNode current = queue.Dequeue();

            // Left child
            if (i < nums.Length && nums[i] != null)
            {
                current._left = new TreeNode(nums[i]);
                queue.Enqueue(current._left);
            }
            i++;

            // Right child
            if (i < nums.Length && nums[i] != null)
            {
                current._right = new TreeNode(nums[i]);
                queue.Enqueue(current._right);
            }
            i++;
        }

        return root;
    }
    #endregion

    static void Main()
    {
        int?[] values = { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1 };
        var tree = BuildTree(values);

        
    }
}