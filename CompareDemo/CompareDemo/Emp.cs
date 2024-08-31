using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompareDemo
{
    public class Emp : IComparable
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public Emp()
        {
            
        }
        public Emp(int id, string name, decimal salary)
        {
            EmpId = id;
            EmpName = name;
            Salary = salary;
        }

        public int CompareTo(object obj)
        {
            Emp xobj = obj as Emp;
            return decimal.Compare(Salary,xobj.Salary);
        }

        public override string ToString()
        {
            return EmpId + "\t" + EmpName + "\t" + Salary;
        }


        public override bool Equals(object? obj)
        {
            Emp xobj = obj as Emp;
            return Salary == xobj.Salary;
        }
    }
}
