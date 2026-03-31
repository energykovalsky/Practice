internal class Program
{
    public class SimpleGenericClass<T>
    {
        public T Field;
    }

    private static void Main(string[] args)
    {
        SimpleGenericClass<string> g = new SimpleGenericClass<string>();
        g.Field = "A string";
        //...
        Console.WriteLine($"SimpleGenericClass.Field           = \"{g.Field}\"");
        Console.WriteLine($"SimpleGenericClass.Field.GetType() = {g.Field.GetType().FullName}");

    }
}