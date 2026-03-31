internal class Program
{
    private static void Main(string[] args)
    {
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        var list = new List<string>(digits);
        var query = list.Where(d => d.Length == 4).ToList();
        list.Remove("four");
        int result = query.Count();

        Console.WriteLine(result);
    }
}