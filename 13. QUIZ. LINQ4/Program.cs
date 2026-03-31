internal class Program
{
    private static void Main(string[] args)
    {
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        var query = from digit in digits
                    where digit.Length == digits.Max(d => d.Length)
                    orderby digit.Substring(1, 2) descending
                    select digit;

        Console.WriteLine($"digits.Max = {digits.Max(d => d.Length)}");
        Console.WriteLine();

        for (int i = 0; i < digits.Length; i++)
        {
            Console.WriteLine($"The length of {digits[i]}: \t {digits[i].Length}");
        }

        Console.WriteLine();

        for (int i = 0; i < digits.Length; i++)
        {
            Console.WriteLine($"The substring of {digits[i]}:\t {digits[i].Substring(1, 2)}");
        }

        Console.WriteLine();

        for(int i = 0; i < digits.Length; i++)
        {
            if (digits[i].Length == digits.Max(d => d.Length))
            {
                Console.WriteLine($"The substring of {digits[i]}:\t {digits[i].Substring(1, 2)}");
            }            
        }

        Console.WriteLine();


        foreach (var element in query)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }
}