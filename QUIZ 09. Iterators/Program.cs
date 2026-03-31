internal class Program
{
    private static void Main(string[] args)
    {
        int i = 5, result;
        IEnumerable<int> integers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        IEnumerator<int> enumerable = integers.GetEnumerator();
        while (i-- > 0) enumerable.MoveNext();
        result = enumerable.Current;
    }
}