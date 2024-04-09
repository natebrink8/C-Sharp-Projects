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
        static void Main(string[] args)
        {
            using (var dataContext = new DataContext())
            {
                var estudiante = new Estudiante() { FirstName = "Pablo" };
                dataContext.Estudiantes.Add(estudiante);
                dataContext.SaveChanges();
            }
        }
    }
}
