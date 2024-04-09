using LMSStep549CodeFirstEFConsoleApp3.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSStep549CodeFirstEFConsoleApp3
{
    class Program
    {
        public static DataContext DataContext { get; private set; }

        static void Main(string[] args)
        {
            DataContext dataContext = new DataContext(@"Data Source=NatesYOGA\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            Estudiante estudiante = new Estudiante()
            {
                FirstName = "Spanky"        // CREATE a table and add a student name.
            };
            dataContext.Estudiantes.Add(estudiante);
            dataContext.SaveChanges();


            EstudiantePermission estudiantePermission = new EstudiantePermission()
            {
                FirstName = "Admin"         // CREATE a Permission table with an Admin in it
            };
            dataContext.EstudiantePermissions.Add(estudiantePermission);
            dataContext.SaveChanges();

            return;
        }
    }
}
