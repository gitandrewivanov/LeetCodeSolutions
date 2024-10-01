namespace LeetCodeEasy.Tasks01102024;

public class RomanToInteger
{
    public static int RomanToIntegerFunc(string s)
    {
        var map = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        var map2 = new Dictionary<char, List<char>>()
        {
            { 'I', new() { 'V', 'X' } },
            { 'X', new() { 'L', 'C' } },
            { 'C', new() { 'D', 'M' } }
        };

        var result = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var current = s[i];
            var next = i + 1 < s.Length ? s[i + 1] : '-';
            if (map2.TryGetValue(current, out var list) && list.Contains(next))
            {
                result += map[next] - map[current];
                i++;
            }
            else
            {
                result += map[current];
            }
        }

        return result;
    }
}