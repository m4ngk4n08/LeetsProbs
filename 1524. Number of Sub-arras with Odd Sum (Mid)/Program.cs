


using System;
using System.Collections.Generic;
using System.Reflection;

int[] arr = { 1,2,3 };
//9
//bruteforce approach O(n3)
//var newList = new List<int>();
int MOD = 1_000_000_007;

//for (int q = 0; q < arr.Length; q++)
//{
//    for (int i = q; i < arr.Length; i++)
//    {
//        var sum = 0;
//        for (int j = q; j <= i; j++)
//        {
//            sum = (sum + arr[j]) % MOD;
//        }
//        if (sum % 2 == 1) newList.Add(sum);
//        Console.WriteLine();
//    }
//}

//var result = newList.Count() % MOD;

//Console.WriteLine();


//// Prefix Sum
//int n = arr.Length;

//int count = 0;
//int temp = 1;
//for (int j = 0; j < n; j++)
//{
//    int[] prefixSum = new int[n];
//    prefixSum[j] = arr[j];

//    for (int i = temp; i < n; i++)
//    {
//        prefixSum[i] = (prefixSum[i - 1] + arr[i]) % MOD;
//    }
//    Console.WriteLine(string.Join(", ", prefixSum));

//    count += prefixSum.Count(j => j % 2 == 1) % MOD;
//    temp++;
//}
//Console.WriteLine();
//1 2 3 4 5
//int count = 0;
//int prefixSum = 0;
//int evenCount = 1; // empty sum (0) is even
//int oddCount = 0;

//foreach (var num in arr)
//{
//    prefixSum = prefixSum + num;

//	if (prefixSum % 2 == 0)
//	{
//		count = (count + oddCount) % MOD;
//		evenCount++;
//	}
//	else
//	{
//		count = (count + evenCount) % MOD;
//		oddCount++;
//	}
//}

//Console.WriteLine(count);
