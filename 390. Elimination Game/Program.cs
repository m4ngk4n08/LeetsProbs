

//var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//var arr2 = new int[] { 2,4,6,8 };

//for (int i = 0; i <= arr.Length; i+=2)
//{
//    Console.WriteLine("arr1: " + i);
//}

//for (int i = arr2.Length; i >= 0; i -= 2)
//{
//    if (i != 0)
//    {
//        Console.WriteLine("arr2: " + arr2[arr2.Length - i]);
//    }
//}
var arrs = new List<int>();

for (int i = 1; i <= 100000000; i++)
{
    arrs.Add(i);
}


var test = LastRemaining(arrs, true);

Console.WriteLine(test);

int LastRemaining(List<int> arr, bool rev)
{
    if (arr.Count == 1)
    {
        return arr[0];
    }

    var temp = new List<int>();

    if (rev)
    {
        for (int i = 1; i < arr.Count; i += 2)
        {
            temp.Add(arr[i]);
        }
    }
    else
    {
        int count = 2;
        for (int i = arr.Count; i > 1; i -= 2)
        {
            temp.Add(arr[arr.Count - count]);
            count += 2;
        }

        temp.Reverse();
    }
    return LastRemaining(temp,!rev);
}