using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetCrudDemo
{
    public static class Helper
    {
        public static string connectionString
        {
            get {
                return "Data Source=RBSLAPTOP;Initial Catalog=MSNETDB;Integrated Security=True;";
            }
        }
    }
}
