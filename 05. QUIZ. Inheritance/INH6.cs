namespace Practice
{
    internal class INH6
    {
        public class Mammal
        {
            public int age;
            public static int count;
        }

        public class Human : Mammal
        {
            public int age;
            public static int count;
            public void Foo(int count)
            {
                ++age;
                ++this.age;
                ++base.age;
                ++count;
                ++Mammal.count;
                ++Human.count;
                string output = $"{age} {this.age} {base.age} {count} {Mammal.count} {Human.count}";
                Console.WriteLine(output);
            }
        }
    }
}
