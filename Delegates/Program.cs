public delegate void SampleDelegate(string message);

class Program
{
    static void MethodOne(string msg)
    {
        Console.WriteLine($"MethodOne: {msg}");
    }

    static void MethodTwo(string msg)
    {
        Console.WriteLine($"MethodTwo: {msg}");
    }

    static void Main()
    {
        // 2. Instantiate the delegate and add methods
        SampleDelegate multiDel = MethodOne;
        multiDel += MethodTwo; // Add another method using the += operator

        // 3. Invoke the multicast delegate
        // Both MethodOne and MethodTwo will be called in order
        multiDel("Hello World");

        // 4. Remove a method using the -= operator
        multiDel -= MethodOne;

        // 5. Invoke again (only MethodTwo is called this time)
        multiDel("Goodbye");
    }
}