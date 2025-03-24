


#region Factorial of number(classic)

//int n = 2;
//int j = 8;


//Console.WriteLine(Factorial(n, j));
//Console.WriteLine();

//int Factorial(int n, int j)
//{
//	if (j <= 0)
//	{
//		return 1;
//	}

//    return n * Factorial(n, j - 1);
//}


#endregion

#region Arturo Fibonacci
//0 1 1 2 3 5
//Console.WriteLine("Arturo" + ArturoFibbonacci(4));
//Console.WriteLine();

//int ArturoFibbonacci(int n)
//{
//	if (n <= 1)
//	{
//		return n;
//	}

//    return ArturoFibbonacci(n - 1) + ArturoFibbonacci(n - 2);
//}
#endregion

#region Sorting
//1 2 3 4
int[] arr = new int[]{ -5,-4,4,3,2,1};

//int left = 0;
//int right = left + 1;
//while (arr[left] > arr[right])
//{
//	var temp = arr[left];
//	arr[left] = arr[right];
//	arr[right] = temp;
//	right++;
//	if (arr[right] < )
//	{

//	}
//}

for (int i = 0; i < arr.Length; i++)
{
	for (int j = i + 1; j < arr.Length; j++)
	{
		if (arr[i] > arr[j])
		{
			Console.WriteLine("before: " + arr[i] + " " + arr[j]);
			var temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
			Console.WriteLine("after: " + arr[i] + " " + arr[j]);
		}
	}
}
var test = arr;
Console.WriteLine();
#endregion