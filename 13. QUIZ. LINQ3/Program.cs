using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        ////A 
        //var query = from digit in digits
        //            group digit by digit[0] into item
        //            orderby item.Count()
        //            select item.Key;

        ////B 
        var query = from digit in digits
                    group digit by digit[0] into item
                    orderby item.Count()
                    select item;

        //C
        var query2 = from digit in digits
                    group digit by digit[0] into item
                    orderby item.Key
                    select item;

        Console.WriteLine("orderby item.Count()");

        foreach (var item in query)
        {
            Console.WriteLine($"{item.Key}: {item.Count()}; ");

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i][0] == item.Key)
                {
                    Console.WriteLine(digits[i]);
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("orderby item.Key");

        foreach (var item in query2)
        {
            Console.WriteLine($"{item.Key}: {item.Count()}; ");

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i][0] == item.Key)
                {
                    Console.WriteLine(digits[i]);
                }
            }
        }
    }
}