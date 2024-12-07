using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation_with_Parametersed_Query
{
    internal class Program
    {
        public static void insert_Operation()
        {

            //Console.WriteLine("Enter Employee ID");
            //int Id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string Name=Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            int Salary=int.Parse(Console.ReadLine());   
            SqlConnection con = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=CRUD_Operation;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tblEmployee values(@Name,@Salary)";
            //cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue ("@Name", Name);
            cmd.Parameters.AddWithValue("@Salary",Salary);
            cmd.CommandType=System.Data.CommandType.Text;
            int n=cmd.ExecuteNonQuery();
            if (n > 0 )
            {
                Console.WriteLine("Record inserted Successfully!!!!");
            }
            else
            {
                Console.WriteLine("Not Record inserted!!!!");
            }
        }
        static void Main(string[] args)
        {
            Program.insert_Operation();
            Console.ReadKey();
        }
    }
}
