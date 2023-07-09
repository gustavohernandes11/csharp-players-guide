namespace Level42;
public static class ThreeLenses
{
    // • All the odd numbers are filtered out, and only the even should be considered. 
    // • The numbers are in order. 
    // • The numbers are doubled.

    public static IEnumerable<int> Procedural(int[] array)
    {
        List<int> result = new();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
                result.Add(array[i] * 2);
        }
        result.Sort();
        return result;
    }

    public static IEnumerable<int> KeywordBased(int[] array)
    {
        return from item in array
               where item % 2 == 0
               orderby item
               select item * 2;

    }

    public static IEnumerable<int> MethodCallBased(int[] array)
    {
        return array
            .Where(item => item % 2 == 0)
            .OrderBy(item => item)
            .Select(item => item * 2);
    }
};
