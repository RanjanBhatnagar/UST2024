using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataSetCrudDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Employee", Helper.connectionString);
            DataSet dataSet = new DataSet();
            //To generate Insert, Update and Delete commands with DA
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            //builder.DataAdapter = da;
            da.Fill(dataSet, "dtEmp");
            Console.WriteLine();

            dataSet = CreateNewEmp(dataSet);
            da.Update(dataSet,"dtEmp");
        }

        public static DataSet CreateNewEmp(DataSet dataSet)
        {
            clsEmployee emp = new clsEmployee();
            emp.EmpName = "Anita";
            emp.DOJ = DateTime.Now;
            emp.City = "Kolkata";
            emp.Salary = 45649M;
            emp.Age = 26;
            emp.MobileNo = "56546767";

            DataRow dr = dataSet.Tables[0].NewRow();
            dr["EmpName"] = emp.EmpName;
            dr["DOJ"] = emp.DOJ;
            dr["City"] = emp.City;
            dr["Salary"] = emp.Salary;
            dr["Age"] = emp.Age;
            dr["MobileNo"] = emp.MobileNo;


            dataSet.Tables[0].Rows.Add(dr);
            return dataSet;
        }
    }
}
