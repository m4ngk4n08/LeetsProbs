
int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
//if (sortedArray == null || sortedArray.Length == 0)
//{
//	return null;
//}
var test = SortedArrayToBST(sortedArray, 0, sortedArray.Length - 1);
Console.WriteLine();
TreeNode SortedArrayToBST(int[] sortedArray, int start, int end)
{
	if (start > end)
	{
		return null;
	}

	int middlePoint = start + (end - start) / 2;

	var root = new TreeNode(sortedArray[middlePoint]);

    root._left =  SortedArrayToBST(sortedArray, start, middlePoint - 1);
	root._right = SortedArrayToBST(sortedArray, middlePoint + 1, end);

	return root;
}
