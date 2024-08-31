using System.Collections;

namespace CompareDemo
{
    public class Program
    {
        static void Main(string[] args)
        {


            List<Emp> list = new List<Emp>();

            Emp e2 = new Emp(102, "Shyam", 45675);
            Emp e5 = new Emp(105, "Anil", 96757);
            Emp e3 = new Emp(103, "Sita", 67578);
            Emp e4 = new Emp(104, "Krishan", 43234);
            Emp e1 = new Emp(101, "Ram", 83432);
            Emp e6 = new Emp(106, "Mahesh", 33555);

            list.Add(e1);
            list.Add(e2);
            list.Add(e3);
            list.Add(e4);
            list.Add(e5);
            list.Add(e6);
            //default sorting is done by implimenting IComparable
            //Sorting will be done by salary in consideration
            // list.Sort();

            foreach (Emp e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("===================================");

            //I want one more criteria i.e. name to perform sorting.
            //So, I need another comparer method in class but IComparable allow me on one implimentation.
            //Solution is define a new class that will be Comparer class
            //You can have n number of Comparers.

            list.Sort(new NameComparer());

            foreach (Emp emp in list)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("===================================");
            list.Sort(new IdComparer());

            foreach (Emp emp in list)
            {
                Console.WriteLine(emp);
            }



            if (e1.Equals(e2)) // boolean return -- true / false
            { 
                Console.WriteLine("Same"); 
            }
            else 
            { 
                Console.WriteLine("Different"); 
            }
        }
    }
}
