namespace MyExtensionDemo
{
    public static class MyMathExt
    {
        public static int Multiply(this MyMath obj, int a, int b)
        {
            return a * b;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            MyMath myMath = new MyMath();
            int s = myMath.Add(12, 345);

            Console.WriteLine($"Sum is:{s}");

            int m = myMath.Multiply(150, 5);
            Console.WriteLine($"Multiplication is{m}");
        }
    }
}
