
int[] nums = [1, 2, 3, 3];

int[] nums2 = [1, 1, 2, 2];
Rotate(nums, 7);

void Rotate(int[] nums, int k)
{
    if (k > nums.Length)
        k = k % nums.Length;

    Array.Reverse(nums);
    Array.Reverse(nums, 0, k);
    Array.Reverse(nums, k, Math.Abs(k - nums.Length));

}


int[] arr = [1,1, 2, 3];
var arrDict = new Dictionary<int, int>();
var returnBool = arr.GroupBy(j => arr.Count(x => x == j)).Select(j => j.Key).ToList();
var test = returnBool.Distinct();

foreach (var item in arr)
{

    if (!arrDict.TryAdd(item, 1))
    {
        arrDict[item]++;
    }
}

var test123 = arrDict.GroupBy(j => j.Value);
int[] outList = new int[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    //outList[i] = arr.Select(j => j).Where(j => arr[i] != j).;
}



Console.WriteLine();