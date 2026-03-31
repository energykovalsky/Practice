internal class Program
{
    private static void Main(string[] args)
    {
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        var query = digits.Where((digit, index) => digit.Length < index);
        var result = string.Empty;


        foreach (var element in query)
        {
            result += $"{element} ";
        }
    }
}