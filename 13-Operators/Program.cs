namespace _13_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5 + 5;
            int y = x + 5;
            int z = x + y;
            float f = 3.5f + 5.25f;
            string greet = "Hello " + "World";

            Console.WriteLine("x: {0}", x);
            Console.WriteLine("y: {0}", y);
            Console.WriteLine("z: {0}", z);
            Console.WriteLine("f: {0}", f);
            Console.WriteLine("greet: {0}", greet);

            // Example: Operator Precedence
            int a = 5 + 3 * 3;
            int b = 5 + 3 * 3 / 2;
            int c = (5 + 3) * 3 / 2;
            int d = (3 * 3) * (3 / 3 + 5);
        }
    }
}
