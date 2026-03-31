internal class Program
{
    private static void Main(string[] args)
    {
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        var result = digits.OrderBy(d => d.Length).Single();

        var result2 = digits.OrderBy(d => d.Length);
    }
}