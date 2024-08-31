using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareDemo
{
    public class NameComparer : IComparer<Emp>
    {
        public int Compare(Emp? x, Emp? y)
        {
            return x.EmpName.CompareTo(y.EmpName);
           // return string.Compare(x.EmpName,y.EmpName);
        }
    }

    public class IdComparer : IComparer<Emp>
    {
        public int Compare(Emp? x, Emp? y)
        {
            return x.EmpId.CompareTo(y.EmpId);
            // return string.Compare(x.EmpName,y.EmpName);
        }
    }
}
