
string s = "(])";

var test = IsValid(s);
Console.WriteLine();
bool IsValid(string s)
{
    var pairs = new Dictionary<char, char> { { '(', ')' }, { '{', '}' }, { '[', ']' } };
    var stackPairs = new Stack<char>();
    foreach (var item in s)
    {
        if (pairs.ContainsKey(item))
        {
            stackPairs.Push(item);
        }

        if (pairs.ContainsValue(item))
        {
            if (stackPairs.Count > 0)
            {
                if (stackPairs.Peek() == pairs.Where(j => j.Value == item).Select(j => j.Key).First())
                {
                    stackPairs.Pop();
                }
                else
                {
                    stackPairs.Push(item);
                }
            }
            else
                return false;
        } 
    }

    return stackPairs.Count > 0 ? false : true;
}