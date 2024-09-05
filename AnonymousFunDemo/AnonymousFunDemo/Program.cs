namespace AnonymousFunDemo
{
    delegate void CountIt();

    delegate void paramCount(int param);
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Function call");
            mycount();

            Console.WriteLine("Using Delegate");
            CountIt dcount = mycount;
            dcount();

            Console.WriteLine("Anonymous Function");
            CountIt count = delegate
            {
                for (int i = 1; i <= 10; i++)
                    Console.Write(i + " ");
                Console.WriteLine();
            };
            count();

            Console.WriteLine("Anonymous Function with parameter");
            paramCount pcount = delegate(int n)
            {
                for (int i = 1; i <= n; i++)
                    Console.Write(i + " ");
                Console.WriteLine();
            };
            pcount(10);
            pcount(5);
        }
        static void mycount()
        {
            for (int i = 1; i <= 10; i++)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
