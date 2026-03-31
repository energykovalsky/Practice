internal class Program
{
    //declares a delegate named Callback
    //that can encapsulate a method that takes a string as an argument and returns void
    public delegate void Callback(string message);

    // Create a method for a delegate.
    public static void DelegateMethod(string message)
    { 
        Console.WriteLine(message); 
    }

    // Defining a custom comparison method and passing that delegate to a sort method.
    // MethodWithCallback doesn't need to call the console directly — 
    // it doesn't have to be designed with a console in mind.
    // What MethodWithCallback does is prepare a string and pass the string to another method.
    // A delegated method can use any number of parameters.
    public static void MethodWithCallback(int param1, int param2, Callback callback) 
    { 
        callback("The number is: " + (param1 + param2).ToString()); 
    }

    public class MethodClass 
    { 
        public void Method1(string message) { } 
        public void Method2(string message) { } 
    }

    private static void Main(string[] args)
    {
        // Instantiate the delegate.
        // Because the instantiated delegate is an object, it can be passed as an argument, or assigned to a property
        Callback handler = DelegateMethod;

        MethodWithCallback(1, 2, handler);

        // Call the delegate.
        handler("Hello World");

        var obj = new MethodClass();
        Callback d1 = obj.Method1;
        Callback d2 = obj.Method2;
        Callback d3 = DelegateMethod;

        //Both types of assignment are valid.
        Callback allMethodsDelegate = d1 + d2; 
        allMethodsDelegate += d3;
        Console.WriteLine(allMethodsDelegate.GetInvocationList().GetLength(0));

        //remove Method1
        allMethodsDelegate -= d1;

        // copy AllMethodsDelegate while removing d2
        Callback oneMethodDelegate = (allMethodsDelegate - d2)!;

        int invocationCount = d1.GetInvocationList().GetLength(0);
        Console.WriteLine(invocationCount);
    }

}