using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class Helper
    {
        public static string ConnectionString
        {
            get
            {
                return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=USTDemoDB;Integrated Security=True";
            }
        }
    }
}
