internal class Program
{
    private static void Main(string[] args)
    {
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        var list = new List<string>(digits);
        var query = from d in list
                    where d.Length == 4
                    select d;
        string[] query2 = query.ToArray();
        
        foreach (var element in query2)
        {
            Console.Write($"{element} ");
        }        

        Console.WriteLine();

        list.Remove("four");
        var result = string.Empty;
        foreach (var element in query)
        {
            result += $"{element} ";
        }
        Console.WriteLine(result);
    }
}