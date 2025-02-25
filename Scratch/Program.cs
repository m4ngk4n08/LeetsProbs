


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
Console.WriteLine("Arturo" + ArturoFibbonacci(4));
Console.WriteLine();

int ArturoFibbonacci(int n)
{
	if (n <= 1)
	{
		return n;
	}

    return ArturoFibbonacci(n - 1) + ArturoFibbonacci(n - 2);
}
#endregion