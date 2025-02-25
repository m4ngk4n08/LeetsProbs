
#region fizzbuzz
//var fizzBuzzDict = new Dictionary<int, string>() { { 3, "fizz" }, { 5, "buzz" }, { 7, "bazz" } };
//var outString = string.Empty;
//for (int i = 0; i < 100; i++)
//{
//    var count = 0;
//    foreach (var myDict in fizzBuzzDict)
//    {
//        if (i % myDict.Key == 0)
//        {
//            count++;
//            outString = myDict.Value;
//        } 

//        if (count == fizzBuzzDict.Count) {
//            outString = "fizzbuzz";
//        }

//        if (count is 0)
//        {
//            outString = i.ToString();
//        }
//    }

//    Console.WriteLine(outString);
//}

#endregion

#region factorial calculation

//long result = calculate(6);

//Console.WriteLine(result);

//static long calculate(int n)
//{
//    if (n == 0 || n == 1)
//    {
//        return 1;
//    }
//    else
//    {
//        return n * calculate(n - 1);
//    }
//}
#endregion

#region palindrome check
//string palindromeCheck = "wilabaliw";
//string reverse = string.Empty;

//for (int i = palindromeCheck.ToCharArray().Length - 1; i >= 0; i--)
//{
//    reverse += palindromeCheck.ToCharArray()[i];
//}

//Console.WriteLine(palindromeCheck == reverse ? true : false);

//var arrayList = new List<int>() { 2, 6, 1, 5, 3, 4};
//bool breakArray = false;
//var index = 1;
//var oldValue = 0;
//var count = 0;
//while (!breakArray)
//{
//    if (arrayList.Count.Equals(index))
//    {
//        index = 1;
//    }

//    if (arrayList[index] < arrayList[index - 1])
//    {
//        oldValue = arrayList[index - 1];
//        arrayList[index - 1] = arrayList[index];
//        arrayList[index] = oldValue;
//        count++;

//        if (count.Equals(arrayList.Count()))
//        {
//            breakArray = true;
//        }
//    }

//    index++;
//}
#endregion

#region skip via index?? wtf.

//var arraylist = new List<int>() { 1, 2, 3, 4, 5 };
//var newarraylist = new List<int>();
//var arrayskipnum = 0;

//for (var i = 0; i < arraylist.Count; i++)
//{
//    if (!i.Equals(arrayskipnum))
//    {
//        newarraylist.Add(arraylist[i]);
//    }
//}

//Console.WriteLine(string.Join(", ", newarraylist));
#endregion

#region character counter

//string newString = "pneumonoultramicroscopicsilicovolcanoconiosis"; //misisipi
//var counter = 0;
//var count = 0;
//var newVesString = string.Empty;
//bool breakCounter = false;


//while(!breakCounter)
//{
//    for (int i = 0; i < newString.ToCharArray().Length; i++)
//    {
//        if (newString.ToCharArray()[i].Equals(newString.ToCharArray()[counter]))
//        {
//            if (newVesString.ToCharArray().Any() && newString.ToCharArray()[counter].Equals(newVesString.ToCharArray()[newVesString.Length - 5]))
//            {
//                if (count != 0)
//                {
//                    count++;
//                    var subNewVesString = newVesString.Substring(Math.Max(newVesString.Length - 5, 0));
//                    var subNewVesStringCount = subNewVesString.Replace(newVesString.Substring(Math.Max(newVesString.Length - 3, 0)), string.Format(" {0};", count.ToString()));
//                    newVesString = newVesString.Replace(subNewVesString, subNewVesStringCount);
//                }
//            }
//            else
//            {
//                if (!newVesString.Contains(newString.ToCharArray()[counter]))
//                {
//                    count++;
//                    newVesString += string.Format("{0}, {1};", newString.ToCharArray()[counter], count);

//                }
//            }
//        }

//    }
//    counter++;
//    count = 0;

//    if (newString.Length.Equals(counter))
//    {
//        Console.WriteLine(newVesString);
//        breakCounter = true;
//    }
//}
#endregion

#region Maximum Product of Two Elements in an Array

//int[] nums = { 3, 4, 5, 2 };
//int temp = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//	if (i <= nums.Length)
//	{
//        if (nums[i] > nums[i + 1])
//        {
//            temp = nums[i];
//            nums[i] = nums[i + 1];
//            nums[i + 1] = temp;
//        }
//    }
//    else
//    {
//        break;
//    }

//}
#endregion

#region twosome

//var nums = new int[2] { 3,3 };
//var target = 7;
//int sum = 0;
//int arrayIndex = 0;

//do
//{

//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (i <= nums.Length && arrayIndex <= nums.Length && i != arrayIndex)
//        {
//            sum = nums[arrayIndex] + nums[i];

//            if (sum == target)
//            {
//                Console.WriteLine(string.Format("{0}, {1}", arrayIndex, i));
//                break;
//            }
//        }
//    }

//    arrayIndex++;

//    if (arrayIndex == nums.Length) break;

//} while (target != sum);
#endregion

#region number palindrome and reverse int
//    var input = 1534236469;
//    double reverse = 0;
//    var temp = input;
//    if (input < 0) Console.WriteLine(false);
//    while (temp != 0)
//    {
//        int remainder = temp % 10;
//        reverse = reverse * 10 + remainder;
//        temp = temp / 10;
//    Console.WriteLine(temp);
//}
//Console.WriteLine((double)reverse);
//Console.WriteLine(reverse == input);

//Console.WriteLine(Reverse(-2147483648));
//int Reverse(int input)
//{
//    // input = 108 - one hundred eight
//    double reverse = 0;
//    var temp = input;

//    while (temp != 0)
//    {
//        // First Loop: remainder = 108 mod 10 = 8 // get the remainder of the input
//        // Sedond Loop: remainder = 10 mod 10 = 0
//        // Third Loop: remainder = 1 mod 10 = 1
//        int remainder = temp % 10;

//        // First Loop:  reverese = 0 * 10 + 8
//        // Second Loop: reverese = 8 * 10 + 0
//        // Third Loop: 80 * 10 + 1 = Reverese final value
//        reverse = reverse * 10 + remainder;

//        // First Loop:  temp = 108 / 10
//        // Second Loop: temp = 10 / 10
//        // Third Loop: temp = 1 / 10 = 0.1
//        // Since the variable is declared as int, decimal value is not allowed. Read value will be 0.
//        // End loop
//        temp = temp / 10;
//    }

//    if (Math.Abs(reverse) > int.MaxValue) return 0;

//    return (int)reverse;
//}
#endregion

#region wordToNumber
//var onesMap = new Dictionary<string, int>
//        {
//            { "one", 1 }, { "two", 2 }, { "three", 3 }, { "four", 4 }, { "five", 5 },
//            { "six", 6 }, { "seven", 7 }, { "eight", 8 }, { "nine", 9 }
//        };

//var tensMap = new Dictionary<string, int>
//        {
//            { "ten", 10 }, { "twenty", 20 }, { "thirty", 30 }, { "forty", 40 },
//            { "fifty", 50 }, { "sixty", 60 }, { "seventy", 70 }, { "eighty", 80 }, { "ninety", 90 },

//            { "eleven", 11 }, { "twelve", 12 }, { "thirteen", 13 }, { "fourteen", 14 },
//            { "fifteen", 15 }, { "sixteen", 16 }, { "seventeen", 17 }, { "eighteen", 18 }, { "nineteen", 19 }
//        };

//var scale = new Dictionary<string, int>
//        {
//            { "hundred", 100 }, { "thousand", 1000 }, { "million", 1000000 }, { "billion", 1000000000 }
//        };

//var numString = "two million three hundred seventeen thousand one hundred";
////1,022,132,399
//var numStringSplit = numString.Split(" ");
//var sum = 0;
//var lastVal = string.Empty;
//var holdVal = 0;
//var count = 1;
//foreach (var item in numStringSplit)
//{
//    if (onesMap.ContainsKey(item))
//    {
//        if (lastVal != "hundred")
//        {
//            if (tensMap.ContainsKey(lastVal))
//            {
//                holdVal += onesMap[item];
//            }
//            else
//            {
//                holdVal = onesMap[item];
//            }

//            if (onesMap.ContainsKey(lastVal))
//            {
//                sum += holdVal;
//            }
//        }
//        else
//        {
//            holdVal += onesMap[item];
//        }
//    }

//    if (tensMap.ContainsKey(item))
//    {
//        if (lastVal != "hundred")
//        {
//            holdVal = tensMap[item];

//            if (tensMap.ContainsKey(lastVal))
//            {
//                sum += holdVal;
//            }
//        }
//        else
//        {
//            holdVal += tensMap[item];
//        }
//    }

//    if (scale.ContainsKey(item))
//    {
//        if (holdVal != 0)
//        {
//            holdVal *= scale[item];
//            if (item != "hundred")
//            {
//                sum += holdVal;
//            }
//        }
//        else
//        {
//            sum *= scale[item];
//        }

//    }

//    if (count == numStringSplit.Length)
//    {
//        sum += holdVal;
//    }

//    lastVal = item;
//    count++;
//}
//Console.WriteLine(sum);
#endregion

#region missing number in array

//var missingNum = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
//int sum = 0;
//int count = 0;
//var missing = 0;
//for (int i = 0; i < missingNum.Length; i++)
//{
//    sum += missingNum[i];
//    count += i;
//    count++;

//}
//for (int i = 0; i < missingNum.Length; i++)
//{
//    sum ^= missingNum[i];
//}

//missing = count - sum;
//Console.WriteLine(sum);

#endregion

#region Find the First Non-Repeating Character

//string word = "ffbbawiizzaaccz";
//bool isValid = Regex.IsMatch(word, "^[a-z]+$");
//var wordSplit = word.ToCharArray();
//var myDict = new Dictionary<char, int>();
//var myDictSumVal = 0;

//if (!isValid)
//{
//	return;
//}

//foreach (var letter in wordSplit)
//{
//	if (!myDict.ContainsKey(letter))
//	{
//		myDict.Add(letter, 1);
//	}
//	else
//	{
//		myDict[letter]++;
//	}
//	myDictSumVal++;
//}

//if (wordSplit.Length.Equals(myDictSumVal) && !myDict.Any(j => j.Value > 1))
//{
//    Console.WriteLine("\0");
//}
//else
//{
//    var test = myDict.Where(j => j.Value <= 1).First();
//    Console.WriteLine(test);
//}

#endregion

#region arturo fibonacci
// 0 1 1 2 3 5 = 8
//int fibnum = 5;
//var fibnumsum = 0;
//var storedval = 1;
//var stored = 0;

//for (int i = 0; i <= fibnum; i++)
//{
//    fibnumsum = stored + storedval;
//    stored = storedval;
//    storedval = fibnumsum;
//}

//console.writeline(fibnumsum);

#endregion

#region Longest Consecutive Sequence
//0, 3, 7, 2, 5, 8, 4, 6, 0, 1
//var storedSequence = new HashSet<int>() { 7, 3, 0, 2, 5, 8, 4, 6, 0, 1 };
//var lastCount = 0;

//foreach (var sequence in storedSequence)
//{
//    var currentCount = 0;

//    if (!storedSequence.Contains(sequence - 1))
//    {
//        var currentSequence = sequence;
//        while (storedSequence.Contains(currentSequence))
//		{
//			currentSequence++;
//            currentCount++;

//		}

//        if (currentCount > lastCount)
//        {
//            lastCount = currentCount;
//        }
//    }
//}

//Console.WriteLine(lastCount);
#endregion

#region Longest Subarray with Sum at Most K

//int[][] jaggedArray = new int[][]
//{

//    new int[] { 1, -1, 0 },
//    new int[] { -1, -1, 1 },
//    new int[] { 3, 4, -7, 1, 3, 3, 1, -4 },
//    new int[] { 1, -1, 1, -1  },
//    new int[] { 1, 2, 3, 4, 5 },
//    new int[] { 1, 1, 1 },
//    new int[] { 1, 2, 3 },
//    new int[] { -313, -462, 381, -374, -249, -123, 704, 477, 982, -684, -372, 779, -68, 593, -254, -930, -142, -369, 811, -621, 682, 167, -125, 565, 438, -137, -683, 257, -454, -256, 306, 635, -571, 52, -59, -411, 628, 895, -509, -9, -722, 926, 79, 392, -720, 94, -190, 902, 96, 486, -147, 363, -24, 604, -265, -680, 529, -462, -477, -384, 991, 319, -520, -799, -95, 705, 528, 684 }

//};
//var arrayOfk = new int[] { 0, -1, 7, 0, 9, 2, 3,339 };
//int[][] jaggedArray = new int[][]
//{
//    new int[] { 1, 2, 3, 4, -5, 5 },

//};
//var arrayOfk = new int[] {9};

//int[][] jaggedArray = new int[][]
//{

//new int[] { -313, -462, 381, -374, -249, -123, 704, 477, 982, -684, -372, 779, -68, 593, -254, -930, -142, -369, 811, -621, 682, 167, -125, 565, 438, -137, -683, 257, -454, -256, 306, 635, -571, 52, -59, -411, 628, 895, -509, -9, -722, 926, 79, 392, -720, 94, -190, 902, 96, 486, -147, 363, -24, 604, -265, -680, 529, -462, -477, -384, 991, 319, -520, -799, -95, 705, 528, 684 }

//};
//var arrayOfk = new int[] { 339 };
//for (int i = 0; i < jaggedArray.Length; i++)
//{
//    Console.WriteLine(Subarray(jaggedArray[i], arrayOfk[i]));
//}
//int Subarray(int[] nums, int k)
//{
//    var maxLength = 0;
//    for (int i = 0; i < nums.Length; i++)
//    {
//        var sum = nums[i];
//        var left = i + 1;
//        while (left != nums.Length)
//        {
//            sum += nums[left];
//            if (sum == k)
//            {
//                maxLength++;
//            }
//            left++;
//        }
//        if (k == nums[i])
//        {
//            maxLength++;
//        }
//    }
//    return maxLength;
//}
//Console.WriteLine(  );
#endregion

#region Remove Letter To Equalize Frequency
var arrayString = new string[] { "abcc", "aazz", "abc", "aabbc", "aaaab", "ab", "aaabbbcc", "abbcc", "cccaaa", "aabb", "a", "aaaaa", "abcd", "aabbcc", "aaaabbbbb", "aabbccd", "xxzzz", "xxxyyzz", "aaabbbcccdddd", "abbbcccd", "cbccca", "babbdd", "aabbcccc", "ddaccb" };

//1     "abcc"          true        Remove 'c' to get all frequencies as 1.
//2	    "aazz"	        false	    Removing any character results in frequencies 1 and 2.
//3	    "abc"	        true	    Removing any character leaves two characters with frequency 1.
//4	    "aabbc"	        true	    Remove 'c' to get frequencies 2 and 2.
//5	    "aaaab"	        true	    Remove 'b' to get a single frequency of 4.
//6	    "ab"	        true	    Removing either character leaves one with frequency 1.
//7	    "aaabbbcc"	    false	    No removal results in equal frequencies.
//8	    "abbcc"	        true	    Remove 'a' to get frequencies 2 and 2.
//9	    "cccaaa"	    false	    Removing any character disrupts the balance.
//10	"aabb"	        false	    Removing one character creates frequencies 1 and 2.
//11    "a"             true        Removing the single character results in an empty string (implicitly equal).
//12	"aaaaa"	        true	    Remove one 'a' to leave four 'a's (all frequencies equal).
//13	"abcd"	        true	    Removing any character leaves three with frequency 1.
//14	"aabbcc"	    false	    Removing any character results in frequencies 1 and 2.
//15	"aaaabbbbb"	    true	    Remove one 'b' to balance frequencies (4 and 4).
//16	"aabbccd"	    true	    Remove 'd' to leave all frequencies as 2.
//17	"xxzzz"	        true	    Remove one 'z' to get frequencies 2 and 2.
//18	"xxxyyzz"	    true	    Remove one 'x' to make all frequencies 2.
//19	"aaabbbcccdddd"	true	    Remove one 'd' to equalize all frequencies to 3.
//20	"abbbcccd"	    false	    No single removal balances frequencies (1, 3, 3, 1 → no valid configuration).
//21	"cbccca"	    false
//22	"babbdd"	    false
//23    "aabbcccc"      false
//24     ddaccb          false
//bString.Count(j => j.Equals('('));
foreach (var word in arrayString)
{
    var myDict = new Dictionary<char, int>();
    var splitWord = word.ToCharArray();
    var count = 0;
    bool isTrulse = false;

    foreach (var letter in splitWord)
    {
        count++;
        if (!myDict.ContainsKey(letter))
        {
            myDict.Add(letter, 1);
        }
        else
        {
            myDict[letter]++;
        }
        Console.WriteLine();
    }

    if (myDict.DistinctBy(j => j.Value).Count() <= 1)
    {
        if (myDict.Select(j => j.Value).Max() > 1 && myDict.Count() != 1)
        {
            isTrulse = false;
        }
        else { isTrulse = true; }
    }
    else
    {
        foreach (var item in myDict)
        {
            myDict[item.Key]--;

            if (myDict.Where(j => j.Value >= 1).DistinctBy(j => j.Value).Count() != 1)
            {
                isTrulse = false;
                myDict[item.Key]++;
            }
            else
            {
                //true
                isTrulse = true;
                break;
            }
        }
    }
    Console.WriteLine(string.Format("{0} {1}", word, isTrulse));
}

#endregion

    #region Generate parenthesis
    //var items = 2;

    //Console.WriteLine(GenerateParenthesises(items));
    //IList<string> GenerateParenthesises(int n)
    //{
    //    var bString = new List<char>();
    //    var outString = new List<string>();
    //    int cOpen = 0; int cClose = 0;
    //    var test = GenerateParenthesis(cOpen, cClose, bString, n, outString);

    //    foreach (var item in test)
    //    {
    //        Console.WriteLine(item);
    //    }

    //    return test;
    //}
    //List<string> GenerateParenthesis(int cOpen, int cClose, List<char> bString, int n, List<string> outString)
    //{
    //    cOpen = bString.Count(j => j.Equals('('));
    //    cClose = bString.Count(j => j.Equals(')'));

    //    if (cOpen == cClose && cClose == n)
    //    {
    //        outString.Add(string.Join("", bString));
    //    }

    //    if (cOpen < n)
    //    {
    //        bString.Add('(');
    //        GenerateParenthesis(cOpen, cClose, bString, n, outString);
    //        bString.RemoveAt(bString.Count - 1);
    //    }

    //    if (cClose < cOpen)
    //    {
    //        bString.Add(')');
    //        GenerateParenthesis(cOpen, cClose, bString, n, outString);
    //        bString.RemoveAt(bString.Count - 1);
    //    }

    //    return outString;
    //}
    #endregion

    #region Subsets(Power set)
    //int[] nums = { 1, 2, 3 };
    //var test = Subsets(nums);

    //Console.WriteLine();

    //IList<IList<int>> Subsets(int[] nums)
    //{

    //    var listNums = new List<int>(); 
    //    IList<IList<int>> outNums = new List<IList<int>>();
    //    var testS = Subsets1(nums, listNums, outNums, 0);
    //    return testS;
    //}

    //IList<IList<int>> Subsets1(int[] nums, List<int> listNums, IList<IList<int>> outNums, int index)
    //{
    //    outNums.Add(new List<int>(listNums));
    //    //Console.WriteLine("[" + string.Join(", ", listNums) + "]");

    //    for (int countI = index; countI < nums.Length; countI++)
    //    {
    //        listNums.Add(nums[countI]);
    //        Subsets1(nums, listNums, outNums, countI + 1);
    //        listNums.RemoveAt(listNums.Count - 1);
    //    }

    //    return outNums;
    //}

    #endregion

    #region Subsets II(with duplicate)

    //using System.Linq;

    //int[] nums = { 4, 4, 4, 1, 4 };

    //Console.WriteLine(Subsets(nums));

    //IList<IList<int>> Subsets(int[] nums)
    //{
    //    var listNums = new List<int>();
    //    var outNum = new List<IList<int>>();

    //    Array.Sort(nums);

    //    return SubsetsII(outNum, listNums, 0);
    //}

    //IList<IList<int>> SubsetsII(List<IList<int>> outNum, List<int> listNums, int count)
    //{
    //    outNum.Add([.. listNums]);
    //    Console.WriteLine("[" + string.Join(", ", listNums) + "]");

    //    for (int i = count; i < nums.Length; i++)
    //    {
    //        if (i > count && nums[i] == nums[i - 1]) continue;

    //        listNums.Add(nums[i]);
    //        SubsetsII(outNum, listNums, i + 1);
    //        listNums.RemoveAt(listNums.Count - 1);
    //    }

    //    return outNum;
    //}

    #endregion

    #region Permutation (All Arrangements)
    //int[] nums = { 1, 2, 3 };
    //var test = Permutation(nums);

    //IList<IList<int>> Permutation(int[] nums)
    //{

    //    var listNums = new List<int>();
    //    var used = new List<int>();
    //    IList<IList<int>> outNums = new List<IList<int>>();
    //    var testS = Proc(nums, listNums, outNums, used);
    //    return testS;
    //}
    ////Input: nums = [1, 2, 3]
    ////Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
    //IList<IList<int>> Proc(int[] nums, List<int> listNums, IList<IList<int>> outNums, List<int> used)
    //{

    //    #region recursive backtrack
    //    if (listNums.Count() == nums.Length)
    //    {
    //        // add listnums
    //        Console.WriteLine("[" + string.Join(", ", listNums) + "]");
    //    }

    //    for (int indexxx = 0; indexxx < nums.Length; indexxx++)
    //    {
    //        if (used.Contains(nums[indexxx])) continue;

    //        listNums.Add(nums[indexxx]);
    //        used.Add(nums[indexxx]);

    //        Proc(nums, listNums, outNums, used);

    //        listNums.RemoveAt(listNums.Count() - 1);
    //        used.Remove(nums[indexxx]);
    //    }

    //    return outNums
    //}
    #endregion

    #region Permutations II

    #endregion

    #region Binary tree traversals
    //class BinaryTree
    //{
    //    public class TreeNode
    //    {
    //        public int val;
    //        public TreeNode left;
    //        public TreeNode right;

    //        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    //        {
    //            this.val = val;
    //            this.left = left;
    //            this.right = right;
    //        }

    //        static TreeNode BuildTree(int[] values, int index)
    //        {
    //            if (index >= values.Length || values[index] == -1)
    //                return null;

    //            TreeNode node = new TreeNode(values[index]);
    //            node.left = BuildTree(values, 2 * index + 1);
    //            node.right = BuildTree(values, 2 * index + 2);

    //            return node;
    //        }

    //        static void Main()
    //        {
    //            int[] values = { 6, 1, 2, 0, -1, 5, 4 }; // -1 represents null nodes
    //            TreeNode root = BuildTree(values, 0);

    //            Console.WriteLine("In Order Traversal: ");
    //            InOrderTraversal(root, new List<int>());
    //            Console.WriteLine();
    //        }
    //        //static void Main()
    //        //{
    //        //    TreeNode root = new TreeNode(1);
    //        //    root.left = new TreeNode(2);
    //        //    root.right = new TreeNode(3);
    //        //    root.left.left = new TreeNode(4);
    //        //    root.left.right = new TreeNode(5);

    //        //    var testNode = new TreeNode();

    //        //    Console.WriteLine("In Order Traversal: ");
    //        //    InOrderTraversal(testNode, new List<int>());
    //        //    Console.WriteLine();

    //        //    Console.WriteLine("Pre Order Traversal: ");
    //        //    PreOrderTraversal(root, new List<int>());
    //        //    Console.WriteLine();

    //        //    Console.WriteLine("Post Order Traversal: ");
    //        //    PostOrderTraversal(root, new List<int>());
    //        //}

    //        static List<int> InOrderTraversal(TreeNode root, List<int> outT)
    //        {
    //            if (root == null)
    //            {
    //                return [];
    //            }

    //            InOrderTraversal(root.left, outT);
    //            Console.Write(root.val);
    //            outT.Add(root.val);
    //            InOrderTraversal(root.right, outT);

    //            return outT;
    //        }

    //        static List<int> PreOrderTraversal(TreeNode tree, List<int> outT)
    //        {
    //            if (tree == null)
    //            {
    //                return [];
    //            }

    //            outT.Add(tree.val);
    //            PreOrderTraversal(tree.left, outT);
    //            PreOrderTraversal(tree.right, outT);

    //            return outT;
    //        }

    //        static List<int> PostOrderTraversal(TreeNode tree, List<int> outT)
    //        {
    //            if (tree == null)
    //            {
    //                return null;
    //            }

    //            PostOrderTraversal(tree.left, outT);
    //            PostOrderTraversal(tree.right, outT);
    //            outT.Add(tree.val);
    //            Console.Write(tree.val);

    //            return outT;
    //        }

    //    }
    //}
    #endregion

    #region Binary Tree
class TreeNode
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

        #region SameTree
        //int[] value1 = { 1, -1 };
        //int[] value2 = { 1, null, -1 };
        //var tree1 = BuildTree(value1, 0);
        //var tree2 = BuildTree(value2, 0);
        //var isSameTree = IsSameTree(tree1, tree2);
        #endregion

        #region Symmetric tree
        //var returnSymTree = SymmetricTree(tree);
        #endregion

        #region PathSum
        //var test = ProcMaxSum(tree, 0, 3);
        //Console.WriteLine(test);
        #endregion

        #region PathSum II
        var pathSumII = PathSumII(tree, 22);
        Console.WriteLine();
        #endregion
    }

    /** PROBLEMS HERE! **/

    #region Same Tree
    static bool IsSameTree(TreeNode tree1, TreeNode tree2)
    {
        var tree1Out = ProcIsSameTree(tree1, new List<int?>());
        var treee2Out = ProcIsSameTree(tree2, new List<int?>());

        if (tree1Out.SequenceEqual(treee2Out))
        {
            return true;
        }

        return false;
    }

    static List<int?> ProcIsSameTree(TreeNode tree, List<int?> values)
    {
        if (tree == null)
        {
            values.Add(null);
            return [];
        }

        // Pre Order Traversal
        values.Add(tree._val);
        ProcIsSameTree(tree._left, values);
        ProcIsSameTree(tree._right, values);

        return values;
    }

    #endregion

    #region Symmetric tree

    static bool SymmetricTree(TreeNode tree)
    {
       var numList = ProcSymmetricTree(tree,tree);
       return numList;
    }

    static bool ProcSymmetricTree(TreeNode tree1, TreeNode tree2)
    {
        if (tree1 == null && tree2 != null || tree1 != null && tree2 == null)
        {
            return false;
        }

        if (tree1 == null && tree2 == null)
        {
            return true;
        }

        if (tree1._val != tree2._val)
        {
            return false;
        }
        // process both side of the tree at the same time
        return ProcSymmetricTree(tree1._left, tree2._right) && ProcSymmetricTree(tree2._left, tree1._right);
    }
    #endregion

    #region PathSum
    //static bool ProcMaxSum(TreeNode tree, int? currentSum, int target)
    //{
    //    // If node is null, no path exists.
    //    if (tree == null)
    //        return false;

    //    // Add current node value to the sum.
    //    currentSum += tree._val;

    //    // Check if we're at a leaf node.

    //    if (tree._left == null && tree._right == null)
    //        return currentSum == target;

    //    // Recurse for left and right subtrees.
    //    return ProcMaxSum(tree._left, currentSum, target) || ProcMaxSum(tree._right, currentSum, target);
    //}


    #endregion

    #region PathSum II
    static IList<IList<int?>> PathSumII(TreeNode root, int targetSum)
    {
        return ProcPathSum(root, targetSum, new List<int?>(), new List<IList<int?>>());
    }
    //5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1
    static List<IList<int?>> ProcPathSum(TreeNode tree, int? targetSum, List<int?> numList, List<IList<int?>> outNums, int? sum = 0)
    {
        if (tree == null)
        {
            return [];
        }

        sum += tree._val;
        numList.Add(tree._val);
        if (tree._left == null && tree._right == null)
        {
            if (sum == targetSum)
            {
                outNums.Add([.. numList]);
            }
        }

        ProcPathSum(tree._left, targetSum, numList, outNums, sum);
        ProcPathSum(tree._right, targetSum, numList, outNums, sum);
        numList.RemoveAt(numList.Count - 1);

        return outNums;
    }
    #endregion
}
#endregion