namespace MSTypeConversions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
//-- Boxing and unboxing in statements. --

            int i = 123;
            // The following line boxes i.
            object o = i;

            o = 123;
            i = (int)o;  // unboxing


//-- Boxing and unboxing in expressions. --

            // String.Concat example.
            // String.Concat has many versions. Rest the mouse pointer on
            // Concat in the following statement to verify that the version
            // that is used here takes three object arguments. Both 42 and
            // true must be boxed.
            Console.WriteLine(String.Concat("Answer", 42, true));

            // List example.
            // Create a list of objects to hold a heterogeneous collection
            // of elements.
            List<object> mixedList = [];

            // Add a string element to the list.
            mixedList.Add("First Group:");

            // Add some integers to the list.
            for (int j = 1; j < 5; j++)
            {
                // Rest the mouse pointer over j to verify that you are adding
                // an int to a list of objects. Each element j is boxed when
                // you add j to mixedList.
                mixedList.Add(j);
            }

            // Add another string and more integers.
            mixedList.Add("Second Group:");
            for (int j = 5; j < 10; j++)
            {
                mixedList.Add(j);
            }

            // Display the elements in the list. Declare the loop variable by
            // using var, so that the compiler assigns its type.
            foreach (var item in mixedList)
            {
                // Rest the mouse pointer over item to verify that the elements
                // of mixedList are objects.
                Console.WriteLine(item);
            }

            // The following loop sums the squares of the first group of boxed
            // integers in mixedList. The list elements are objects, and cannot
            // be multiplied or added to the sum until they are unboxed. The
            // unboxing must be done explicitly.
            var sum = 0;
            for (var j = 1; j < 5; j++)
            {
                // The following statement causes a compiler error: Operator
                // '*' cannot be applied to operands of type 'object' and
                // 'object'.
                //sum += mixedList[j] * mixedList[j];

                // After the list elements are unboxed, the computation does
                // not cause a compiler error.
                sum += (int)mixedList[j] * (int)mixedList[j];
            }

            Console.WriteLine($"Sum: {sum}");

            // Output:
            // Answer42True
            // First Group:
            // 1
            // 2
            // 3
            // 4
            // Second Group:
            // 5
            // 6
            // 7
            // 8
            // 9
            // Sum: 30


//-- Boxing and unboxing in statements. --
            i = 123;
            // Boxing copies the value of i into object o.
            o = i;

            i = 123;
            o = (object)i;  // explicit boxing

            Console.WriteLine();

            // Create an int variable
            i = 123;

            // Box the value type into an object reference
            o = i;  // boxing

            // Display the initial values
            Console.WriteLine($"Value of i: {i}");
            Console.WriteLine($"Value of boxed object o: {o}");

            // Modify the original value type
            i = 456;

            // Display the values after modification
            Console.WriteLine("\nAfter changing i to 456:");
            Console.WriteLine($"Value of i: {i}");
            Console.WriteLine($"Value of boxed object o: {o}");
            Console.WriteLine();
            // Output:
            // Value of i: 123
            // Value of boxed object o: 123

            // After changing i to 456:
            // Value of i: 456
            // Value of boxed object o: 123


//-- Boxing and unboxing in expressions. --
            i = 123;            // a value type
            o = i;              // boxing
            int k = (int)o;     // unboxing


//-- Unboxing with an incompatible type. --
            i = 123;
            o = i;  // implicit boxing

            try
            {
                k = (short)o;  // attempt to unbox

                Console.WriteLine("Unboxing OK.");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine($"{e.Message} Error: Incorrect unboxing.");
            }

            Console.WriteLine();

// Attempt to unbox o to an incompatible type.
            try
            {
                k = (int)o;  // attempt to unbox

                Console.WriteLine("Unboxing OK.");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine($"{e.Message} Error: Incorrect unboxing.");
            }

            Console.WriteLine();



        }
    }
}