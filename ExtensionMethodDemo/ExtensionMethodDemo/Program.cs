namespace ExtensionMethodDemo
{
    //below is an extension method for strings.
    public static class MyExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "ram kumar";
            Console.WriteLine(name);
            string uname = name.ToUpper();
            Console.WriteLine(uname);

            //below is LINQ example using inbuilt OrderBy extension method
            int[] ints = [10, 45, 15, 39, 21, 26];
            var result = ints.OrderBy(g => g);
            foreach (var i in result)
            {
                System.Console.Write(i + " ");
            }
            Console.WriteLine();
            //using extension method.
            string str = "My Name is Ranjan Bhatnagar";
            Console.WriteLine($"String \"{str}\" has {str.WordCount()} words.");
        }
    }
}
