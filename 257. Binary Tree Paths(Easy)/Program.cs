


using System.Text;


var test = BinaryTreePaths(
	TreeNode.BuildTree(
						[1, 2, 3, null, 5]),
						new List<int?>(),
						new List<string>()
	);
Console.WriteLine();
IList<string> BinaryTreePaths(TreeNode root, List<int?> inInt, List<string> outString)
{
	if (root == null)
	{
		return outString;
    }

    inInt.Add(root._val);
	if (root._left == null && root._right == null)
	{
		outString.Add(string.Join("->", inInt));
	}
	
	BinaryTreePaths(root._left, inInt, outString);
	BinaryTreePaths(root._right, inInt, outString);
	inInt.RemoveAt(inInt.Count - 1);

	return outString;
}