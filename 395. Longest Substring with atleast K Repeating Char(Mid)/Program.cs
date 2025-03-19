
/*
    Given a string s and an integer k

    return the length of the longest substring of s such that the 
    frequency of each character in this substring is 
    greater than or equal to k.

    if no such substring exists, return 0.

    observation:
        there will be counting character
        take portion of s with a size of k
        store it to substring
        proceed to next portion
        check if current portion has a repeated character of last portion
        store and continue
        
        continiously update the maxCount.

 ababbc
 ab ba ab bb bc
 ababbcd
 ab ba ab bb bc ef
"aaabb"	 3
ababbc 2
ababacb 3
baaabcb 3

Characters appearing < k times break the sequence and act as split points.
Valid substrings before & after the break still count if they meet the k condition.
The longest valid substring after breaking should be returned.
*/

using System.Data.SqlTypes;
using System.Text;

var test = LongestSubstring("aaabbccddeeefff", 3);

int LongestSubstring(string s, int k)
{
    int left = 0;
    int maxCount = 0;
    var sDict = new Dictionary<char, int>();
    for (int right = 0; right < s.Length; right++)
    {
        if (!sDict.ContainsKey(s[right]))
        {
            if (sDict.Any(j => j.Value >= k))
            {
                if (!sDict.Any(j => j.Value < k))
                {
                    maxCount = Math.Max(maxCount, sDict.Values.Sum());
                }
                else
                {
                    sDict.Clear();
                }
            }
            sDict.Add(s[right], 1);
        }
        else
        {
            sDict[s[right]]++;
        }
       
    }

    return maxCount;
}


//Example 1:

//    Input: s = "aaabb", k = 3
//    Output: 3
//    Explanation: The longest substring is "aaa", as 'a' is repeated 3 times.
//    Example 2:

//    Input: s = "ababbc", k = 2
//    Output: 5
//    Explanation: The longest substring is "ababb", as 'a' is repeated 2 times and 'b' is repeated 3 times.

//        ababbc
//        ab ba ab bb bc
//        ababbcd
//        ab ba ab bb bc ef