internal class Program
{
    private static void Main(string[] args)
    {
        string sentence = "The quick brown fox jumps over the lazy dog";
        string[] animals = { "cat", "dog", "elephant" };
        bool result1 = true;

        foreach (string animal in animals)
        {
            if (!sentence.Contains(animal))
            {
                result1 = false;
                break;
            }
        }

        // The `Any` method checks if any element in the collection satisfies the condition. In this case, it will return true because at least one animal (dog) is present in the sentence.
        bool result2 = animals.Any(word => sentence.Contains(word));
        Console.WriteLine(result2);

        // The `All` method checks if all elements in the collection satisfy the condition. In this case, it will return false because not all animals are present in the sentence.
        bool result3 = animals.All(word => sentence.Contains(word));
        Console.WriteLine(result2);

        // The `Contains` method does not accept a lambda expression. It is used to check if a specific element exists in a collection, not to evaluate a condition for each element.
        //bool result4 = animals.Contains(word => sentence.Contains(word));
        //Console.WriteLine(result2);

        // The `Includes` method does not exist in C#. The correct method to use is `Any` or `All` depending on the desired logic.
        //bool result5 = animals.Includes(word => sentence.Contains(word));
        //Console.WriteLine(result2);
    }
}