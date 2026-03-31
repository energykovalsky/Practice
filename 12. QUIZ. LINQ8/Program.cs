internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        var query = (from number in numbers select digits[number]).Take(5);
        
        for (int i = 0; i < query.Count(); i++)
        {
            Console.WriteLine($"{numbers[i]}: {query.ElementAt(i)}");
        }
        Console.WriteLine();
        
        for (int i = 0; i < query.Count(); i++)
        {
            Console.WriteLine($"{numbers[i]}: {query.ToArray()[i]}");
        }
        Console.WriteLine();

        for (int i = 0; i < query.Count(); i++)
        {
            Console.WriteLine($"{numbers[i]}: {query.ToList()[i]}");
        }

        Console.WriteLine();

        var result = string.Empty;
        foreach (var q in query)
        {
            result += $"{q} ";
            Console.WriteLine(q);
        }
        Console.WriteLine(result);
    }
}