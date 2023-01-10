namespace delegate_basic
{
    internal class Program
    {
        delegate int MyDelegate(int a, int b);

        static int TestMethodA(int x, int y)
        {
            System.Console.WriteLine("X + Y = "  + (x + y) + "\n");
            return x + y;
        }

        static int TestMethodB(int x, int y)
        {
            System.Console.WriteLine("X * Y = " + (x * y) + "\n");
            return x * y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyDelegate md = null;

            md += TestMethodA;
            md += TestMethodB;

            md.Invoke(1,2);

        }
    }
}