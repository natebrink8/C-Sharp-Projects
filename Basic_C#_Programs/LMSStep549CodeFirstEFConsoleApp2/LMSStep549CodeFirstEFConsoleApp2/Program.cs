using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace LMSStep549CodeFirstEFConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();

            Console.WriteLine("Please enter your first name.");
            var stuFname = Console.ReadLine();
            students.FirstName = stuFname;

            Console.WriteLine("\nYour name has been added to our database.");
            Console.ReadLine();
        }

        private static void UpdateStudentDbMethod(Students stud)
        {
            Students studs = new Students();
            var stustu = studs.FirstName;

            string connectionstring = @"Data Source = NatesYOGA\SQLEXPRESS; Initial Catalog = Student; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            string queryString = @"INSERT INTO Student (FirstName) VALUE " + stustu + "\"";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.Parameters.AddWithValue(stud.FirstName, System.Data.SqlDbType.VarChar);
                command.Parameters[stustu].Value = stud.FirstName;
                connection.Close();
            }

            View(Program.UpdateStudentDbMethod);    // TRYING TO EXECUTE THE METHOD to write to the dB
        }
    }
}
