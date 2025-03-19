

var romanDict = new Dictionary<char, int>() {
    { 'I', 1},
    { 'V', 5},
    { 'X', 10},
    { 'L', 50},
    { 'C', 100},
    { 'D', 500},
    { 'M', 1000},
};
Console.WriteLine(RomanToInt("MCMXCIV"));
//1994

// IV = 4
// VI = 6
int RomanToInt(string s)
{
    var outInt = 0;

    for (int i = 0; i < s.Length; i++)
    {
        var currentVal = romanDict[s[i]];

        if (i < s.Length - 1)
        {
            var nextVal = romanDict[s[i + 1]];

            if (currentVal < nextVal)
            {
                outInt += nextVal - currentVal;
                i++;
                continue;
            }
        }

        outInt += currentVal;
    }

    return outInt;
}