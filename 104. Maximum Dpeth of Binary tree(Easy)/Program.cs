
var treeNode = new TreeNode(null);
var input = new int?[] { 1,2,3,4,5 };

var test = MaxDepth(TreeNode.BuildTree(input));
Console.WriteLine(test);
int MaxDepth(TreeNode root, int count = 0)
{
    if (root == null)
    {
        return count;
    }
    count += 1;
    
    int left = MaxDepth(root._left, count);
    int right = MaxDepth(root._right, count);

    return Math.Max(left, right);
}